using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record PaymentOptionsDto
	{
		public bool AcceptsCreditCards { get; init; }
		public bool AcceptsDebitCards { get; init; }
		public bool AcceptsCashOnly { get; init; }
		public bool AcceptsNfc { get; init; }
	}
}
