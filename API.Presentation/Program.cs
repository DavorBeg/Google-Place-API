using FluentValidation;
using static System.Net.Mime.MediaTypeNames;

namespace PlacesAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			builder.Services.AddValidatorsFromAssembly(typeof(Validators.Application.AssemblyReference).Assembly);
			builder.Services.AddMediatR(config =>
			{
				config.RegisterServicesFromAssembly(typeof(CQRS.Application.AssemblyReference).Assembly);
			});

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
