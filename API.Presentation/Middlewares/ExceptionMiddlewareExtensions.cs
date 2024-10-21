using Contracts.Domain.Services;
using Exceptions.Domain;
using Exceptions.Domain.Abstraction;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace API.Presentation.Middlewares
{
	public static class ExceptionMiddlewareExtensions
	{
		public static void ConfigureExceptionHandler(this WebApplication app, ILoggerManager logger)
		{
			app.UseExceptionHandler(appError =>
			{
				appError.Run(async context =>
				{
					context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
					context.Response.ContentType = "application/json";

					var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
					if (contextFeature != null)
					{

						context.Response.StatusCode = contextFeature.Error switch
						{
							NotFoundException => StatusCodes.Status404NotFound,
							_ => StatusCodes.Status500InternalServerError
						};

						logger.LogError($"ERROR: {contextFeature.Error}");

						await context.Response.WriteAsync(new ErrorDetails()
						{

							StatusCode = context.Response.StatusCode,
							Message = contextFeature.Error.Message,

						}.ToString());

					}
				});
			});
		}
	}
}
