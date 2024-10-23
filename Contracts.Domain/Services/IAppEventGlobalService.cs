using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Services
{
	public interface IAppEventGlobalService
	{
		public Task SendAsync(string requestName, object msgParams);
	}
}
