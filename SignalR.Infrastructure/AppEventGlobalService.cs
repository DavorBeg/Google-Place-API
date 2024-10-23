using Contracts.Domain;
using Contracts.Domain.Services;
using Entities.Domain.Google;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Infrastructure
{
	public class AppEventGlobalService : IAppEventGlobalService
	{

		private readonly IHubContext<EventHub> _eventHubContext;
		public AppEventGlobalService(IHubContext<EventHub> eventHubContext)
        {
			this._eventHubContext = eventHubContext;   
        }

		public async Task SendAsync(string requestName, object parameters) =>
			await _eventHubContext.Clients.All.SendAsync(requestName, parameters);

	}
}
