using ConfigurationModels.Domain;
using Contracts.Domain.Services;
using Entities.Domain.Auth;
using Logger.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository.Infrastructure;
using Services.Application;
using System.Text;

namespace API.Presentation.Extensions
{
	public static class ExtensionMethods
	{
		public static void ConfigureLoggerService(this IServiceCollection services) =>
			services.AddSingleton<ILoggerManager, LoggerManager>();

		public static void ConfigureCors(this IServiceCollection services) =>
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy", b =>
				{
					b.AllowAnyOrigin();
					b.AllowAnyMethod();
					b.AllowAnyHeader();
					b.WithExposedHeaders("X-Pagination");
				});
			});

		public static void ConfigureAuthenticationService(this IServiceCollection services) =>
			services.AddScoped<IAuthenticationService, AuthenticationService>();

		public static void ConfigureServiceManager(this IServiceCollection services) =>
			services.AddScoped<IServiceManager, ServiceManager>();

		public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
			services.AddDbContext<RepositoryContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("sqlConnection")).UseLazyLoadingProxies();
			});
		public static void ConfigureIdentity(this IServiceCollection services)
		{
			var builder = services.AddIdentity<User, IdentityRole>(opt =>
			{
				opt.Password.RequireDigit = true;
				opt.Password.RequireLowercase = true;
				opt.Password.RequireUppercase = true;
				opt.Password.RequireNonAlphanumeric = true;
				opt.Password.RequiredLength = 10;
				opt.User.RequireUniqueEmail = true;
			})
			.AddEntityFrameworkStores<RepositoryContext>()
			.AddDefaultTokenProviders();
		}

		public static void AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration) =>
			services.Configure<JwtConfiguration>(configuration.GetSection("JwtSettings"));


		public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
		{
			var jwtConfig = new JwtConfiguration();

			configuration.Bind(jwtConfig.ToString(), jwtConfig);
			services.AddAuthentication(opt =>
			{
				opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = jwtConfig.ValidIssuer,
					ValidAudience = jwtConfig.ValidAudience,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Secret ?? throw new NullReferenceException("Secret is not defined, null value returned.")))
				};
			});
		}
	}
}
