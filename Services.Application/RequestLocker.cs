using Contracts.Domain.Services;
using System.Collections.Concurrent;

namespace Services.Application
{
	public class RequestLocker : IRequestLocker
	{
		public ConcurrentDictionary<string, SemaphoreSlim> ConcurrentRequestList => _ConcurentRequestList;
		private ILoggerManager _loggerManager;
		
		private readonly ConcurrentDictionary<string, SemaphoreSlim> _ConcurentRequestList;
        public RequestLocker(ILoggerManager loggerManager)
        {
			_loggerManager = loggerManager;	
			_ConcurentRequestList = new ConcurrentDictionary<string, SemaphoreSlim> { };
        }
        public async Task<T> Trigger<T>(string user, Func<Task<T>> action, string? actionId)
		{
			var userSemaphore = _ConcurentRequestList.GetOrAdd(user, _ => new SemaphoreSlim(1, 1));
			await userSemaphore.WaitAsync();
			try
			{
				_loggerManager.LogDebug($"User: {user} assigned new semphore for his/her task. Action ID is: || {actionId} ||");
				var result = await action();
				_loggerManager.LogDebug($"User: {user} Finished activated task, semaphore release must be triggered.");
				return result;
			}
			catch (Exception error)
			{
				_loggerManager.LogError($"Error occured inside request locker service. User: {user} maybe missed one request response action.");
				_loggerManager.LogError(error.Message);
				throw;
			}
			finally
			{
				userSemaphore.Release();
				_loggerManager.LogDebug($"User: {user} disposed semphore, Action with ID || {actionId} || is finished. Next may enter...");
			}

		}
	}
}
