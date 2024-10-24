using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Domain.Repositories;
using Entities.Domain.Auth;
using Microsoft.EntityFrameworkCore;

namespace Repository.Infrastructure.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly RepositoryContext _context;
        public UserRepository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserById(Guid id)
		{
			return await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Id == id.ToString());
		}
	}
}
