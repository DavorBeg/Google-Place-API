using API.Presentation.Extensions;

namespace PlacesAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			builder.Services.ConfigureSqlContext(builder.Configuration);


			builder.Services.AddAuthentication();
			builder.Services.ConfigureIdentity();
			builder.Services.ConfigureJWT(builder.Configuration);




			var app = builder.Build();

			// Configure the HTTP request pipeline.

			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
