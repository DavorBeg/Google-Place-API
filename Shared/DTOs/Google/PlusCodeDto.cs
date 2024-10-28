using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record PlusCodeDto
	{
		public string GlobalCode { get; init; } = null!;
		public string CompoundCode { get; init; } = null!;
	}
}
