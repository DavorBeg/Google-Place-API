using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class OpeningHours
	{
		public List<string> WeekdayText { get; set; } = new List<string>();
		public bool? OpenNow { get; set; }
	}
}
