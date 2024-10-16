using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Services
{
	public interface IServiceManager
	{
		IAuthenticationService AuthenticationService { get; }
	}
}
