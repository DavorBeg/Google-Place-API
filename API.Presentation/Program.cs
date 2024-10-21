using API.Presentation.Extensions;
using MediatR;
using Serilog;
using static System.Net.Mime.MediaTypeNames;

namespace PlacesAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			Log.Logger = new LoggerConfiguration()
				.ReadFrom.Configuration(builder.Configuration)
				.CreateLogger();

			builder.Services.ConfigureCors();
			builder.Services.ConfigureLoggerService();
			builder.Services.AddJwtConfiguration(builder.Configuration);

			builder.Services.AddControllers();
			builder.Services.ConfigureSqlContext(builder.Configuration);

			builder.Services.ConfigureAuthenticationService();

			builder.Services.AddAuthentication();
			builder.Services.ConfigureIdentity();
			builder.Services.ConfigureJWT(builder.Configuration);


			builder.Services.AddAutoMapper(typeof(Program));

			builder.Services.AddMediatR(config =>
			{
				config.RegisterServicesFromAssembly(typeof(CQRS.Application.AssemblyReference).Assembly);
			});

			var app = builder.Build();
			app.UseCors("CorsPolicy");
			// Configure the HTTP request pipeline.

			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
