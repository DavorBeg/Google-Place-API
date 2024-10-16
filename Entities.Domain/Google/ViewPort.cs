using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Viewport
	{
		public LatLng Northeast { get; set; } = null!;
		public LatLng Southwest { get; set; } = null!;
	}

}
