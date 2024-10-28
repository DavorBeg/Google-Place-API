using Contracts.Domain.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.Application
{
	public class UserAccessor : IUserAccessor
	{

        private readonly IHttpContextAccessor _contextAccessor;
        public UserAccessor(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
			_contextAccessor = _contextAccessor ?? throw new ArgumentNullException(nameof(_contextAccessor));
		}
		public ClaimsPrincipal User => _contextAccessor.HttpContext.User;
    }
}
