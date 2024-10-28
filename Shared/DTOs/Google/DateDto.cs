using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record DateDto
	{
		public long Year { get; init; } 
		public long Month { get; init; } 
		public long Day { get; init; } 
	}
}
