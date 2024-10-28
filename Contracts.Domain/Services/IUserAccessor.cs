using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Services
{
	public interface IUserAccessor
	{
		ClaimsPrincipal User { get; }
	}
}
