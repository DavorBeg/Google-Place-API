using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PlacesAPI;
using Repository.Infrastructure;

namespace API.Presentation.ContextFactory
{
	public class ContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
	{
		public RepositoryContext CreateDbContext(string[] args)
		{
			var assembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
#if DEBUG
				.AddJsonFile("appsettings.Development.json")
#else
				.AddJsonFile("appsettings.json")
#endif
				.Build();

			var builder = new DbContextOptionsBuilder<RepositoryContext>()
				.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
				{
					b.MigrationsAssembly(assembly);
				});

			return new RepositoryContext(builder.Options);
		}
	}
}
