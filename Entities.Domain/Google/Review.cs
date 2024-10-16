using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Review
	{
		public string AuthorName { get; set; } = string.Empty;
		public double Rating { get; set; }
		public string Text { get; set; } = string.Empty;
		public DateTime Time { get; set; }
	}
}
