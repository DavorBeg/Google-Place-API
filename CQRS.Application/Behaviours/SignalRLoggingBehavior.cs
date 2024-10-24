using Contracts.Domain.Services;
using CQRS.Application.Commands.GoogleFeature;
using MediatR;
using Shared.DTOs.SignalR;
using System.Security.Claims;

namespace CQRS.Application.Behaviours
{
	public class SignalRLoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
	{

		private readonly IAppEventGlobalService _signalREventService;
		public SignalRLoggingBehavior(IAppEventGlobalService signalREventService)
        {

			this._signalREventService = signalREventService;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			if (request is SearchPlacesForLocationCommand command)
			{
				var userName = command.user.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier, StringComparison.OrdinalIgnoreCase))?.Value;
				var msg = new LocationRequestParamsDto()
				{
					User = userName ?? "Undefined user",
					IncludedTypes = command.searchParams.includedTypes,
					MaxResultCount = command.searchParams.maxResultCount,
					Circle = command.searchParams.locationRestriction.Circle
				};
				await this._signalREventService.SendAsync(msg.RequestName, msg);
			}

			var response = await next();
			return response;
		
		}
	}
}
