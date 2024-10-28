using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Services
{
	public interface IRequestLocker
	{
		public ConcurrentDictionary<string, SemaphoreSlim> ConcurrentRequestList { get; }
		public Task<T> Trigger<T>(string user, Func<Task<T>> action, string? actionId);
	}
}
