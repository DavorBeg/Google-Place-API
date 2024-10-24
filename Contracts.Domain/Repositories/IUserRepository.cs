using Entities.Domain.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Repositories
{
	public interface IUserRepository
	{
		public Task<User?> GetUserById(Guid id);
	}
}
