using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class SubDestination
	{
		public string Name { get; set; } = string.Empty;
		public LatLng Location { get; set; } = new LatLng();
	}
}
