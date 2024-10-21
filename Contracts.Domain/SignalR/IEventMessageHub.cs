using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.SignalR
{
	public interface IEventMessageHub
	{
		Task SendSearchReportToClient(string user, Location location, float radius);
	}
}
