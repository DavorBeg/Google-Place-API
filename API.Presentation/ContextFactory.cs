using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository.Infrastructure;

namespace API.Presentation
{
	public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
	{

		// I copied example from codemaze book
		// "this class will help our application create a derived DbContext instance during the design, which will help us with migration"
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
				.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
				b =>
				{
					b.MigrationsAssembly("API.Presentation");
				});

			return new RepositoryContext(builder.Options);


		}
	}
}
