using Contracts.Domain.Services;
using CQRS.Application.Commands;
using MediatR.Pipeline;


namespace CQRS.Application.Behaviours
{
	public class RequestExceptionHandler<TRequest, TResponse, TException> :
		IRequestExceptionHandler<TRequest, TResponse, TException> where TResponse : class, new()
																  where TException : Exception
																  where TRequest : notnull
	{

		private readonly ILoggerManager _logger;
        public RequestExceptionHandler(ILoggerManager logger)
        {
            _logger = logger;
        }

        public Task Handle(TRequest request, TException exception, RequestExceptionHandlerState<TResponse> state, CancellationToken cancellationToken)
		{
			_logger.LogError($"Error is catched inside RequestException mediatR middleware on request of type: {typeof(TRequest)}");
			return Task.CompletedTask;
		}
	}
}
