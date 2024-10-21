using CQRS.Application.Commands.GoogleFeature;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Behaviours
{
	public class SignalRLoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
	{
		public SignalRLoggingBehavior()
        {
            
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			if(request is SearchPlacesForLocationCommand)
			{
				// to do implement signal R 
			}

			var response = await next();
			return response;
		
		}
	}
}
