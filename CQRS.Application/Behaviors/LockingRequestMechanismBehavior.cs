using Contracts.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRS.Application.Behaviors
{
	public class LockingRequestMechanismBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
	{
		private readonly IRequestLocker _requestLocker;
		private readonly IUserAccessor _userAccessor;

        public LockingRequestMechanismBehavior(IRequestLocker requestLocker, IUserAccessor userAccessor)
        {
            _requestLocker = requestLocker;
			_userAccessor = userAccessor;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			Random rnd = new Random();

			var user = _userAccessor.User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier, StringComparison.OrdinalIgnoreCase))?.Value;
			if (user is null) return await next();
			else {
				return await _requestLocker.Trigger(user, async () =>  await next(), rnd.Next(100).ToString());
			}

		}
	}
}
