using API.Presentation.Extensions;
using API.Presentation.Middlewares;
using Contracts.Domain;
using Contracts.Domain.Services;
using CQRS.Application.Behaviours;
using MediatR;
using MediatR.Pipeline;
using Serilog;
using SignalR.Infrastructure;

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

			builder.Services.ConfigureAPIVersioning();

			builder.Services.AddSignalR();
			builder.Services.ConfigureCors();
			builder.Services.ConfigureLoggerService();
			builder.Services.AddJwtConfiguration(builder.Configuration);
			builder.Services.AddGoogleConfiguration(builder.Configuration);

			builder.Services.AddControllers();
			builder.Services.ConfigureSqlContext(builder.Configuration);

			builder.Services.ConfigureAuthenticationService();
			builder.Services.ConfigureGoogleService();

			builder.Services.AddAuthentication();
			builder.Services.ConfigureIdentity();
			builder.Services.ConfigureJWT(builder.Configuration);


			builder.Services.AddAutoMapper(typeof(Program));
			builder.Services.AddTransient(typeof(IRequestExceptionHandler<,,>), typeof(RequestExceptionHandler<,,>));
			builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(SignalRLoggingBehavior<,>));

			builder.Services.AddScoped<IAppEventGlobalService, AppEventGlobalService>();

			builder.Services.AddMediatR(config =>
			{
				config.RegisterServicesFromAssembly(typeof(CQRS.Application.AssemblyReference).Assembly);
			});

			

			var app = builder.Build();
			app.UseCors("CorsPolicy");


			var logger = app.Services.GetRequiredService<ILoggerManager>();
			app.ConfigureExceptionHandler(logger);


			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.MapHub<EventHub>("eventHub");
			app.Run();
		}
	}
}
