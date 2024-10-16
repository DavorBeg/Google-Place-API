using Entities.Domain.Auth;
using Entities.Domain.Google;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure
{
	public class RepositoryContext : IdentityDbContext<User>
	{
		public DbSet<Place>? Places { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new RoleConfiguration());
		}
	}
}
