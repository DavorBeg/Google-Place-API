using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class AddressComponent
	{
		public string LongName { get; set; } = string.Empty;
		public string ShortName { get; set; } = string.Empty;
		public List<string> Types { get; set; } = new List<string>();
	}
}
