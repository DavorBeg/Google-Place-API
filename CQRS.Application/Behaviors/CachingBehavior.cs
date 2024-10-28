using Contracts.Domain;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Behaviors
{
	public class CachingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
	{
		private readonly IMemoryCache _memoryCache;
        public CachingBehavior(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			TResponse response;
			if (request is ICacheableCommand cacheQuery)
			{
				object? cachedResponse; 
				_memoryCache.TryGetValue(cacheQuery.CacheKey, out cachedResponse);

				if (cachedResponse != null) {
					response = (TResponse)cachedResponse;
				}
				else
				{
					response = await next.Invoke();
					// Expiration is hardcoded, could be in appsettings, but at this point it does not matter
					_memoryCache.Set(cacheQuery.CacheKey, response, DateTime.Now.AddMinutes(15));
				}
				return response;
			}

			return await next.Invoke();

		}
	}
}
