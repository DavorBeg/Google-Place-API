using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class GenerativeSummary
	{
		public string Summary { get; set; } = string.Empty;
		public string GeneratedBy { get; set; } = string.Empty;
	}
}
