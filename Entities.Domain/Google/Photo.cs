using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Photo
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public List<string>? HtmlAttributions { get; set; }
		public string? PhotoReference { get; set; }
	}
}
