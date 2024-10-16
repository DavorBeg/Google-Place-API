using AutoMapper;
using ConfigurationModels.Domain;
using Contracts.Domain.Services;
using Entities.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Application
{
	public class ServiceManager : IServiceManager
	{
		private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IOptions<JwtConfiguration> configuration)
        {
			_authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
		}

		public IAuthenticationService AuthenticationService => _authenticationService.Value;
	}
}
