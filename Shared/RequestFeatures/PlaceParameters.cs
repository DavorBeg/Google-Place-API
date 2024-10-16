using Shared.RequestFeatures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures
{
	public class PlaceParameters : RequestParameters
	{
		public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();
		public string SearchTerm { get; set; } = string.Empty;
	}
}
