using Contracts.Domain.SignalR;
using Entities.Domain.Google;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Protocol;


namespace SignalR.Infrastructure
{
	public class EventHub : Hub<IEventMessageHub>
	{
		public async Task SendSearchReportToClient(string user, Location location, float radius)
		{
			await Clients.All.SendSearchReportToClient(user, location, radius);
		}
	}
}
