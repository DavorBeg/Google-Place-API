using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class PaymentOptions
	{
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("acceptsCreditCards")]
		public bool AcceptsCreditCards { get; set; }

		[JsonProperty("acceptsDebitCards")]
		public bool AcceptsDebitCards { get; set; }

		[JsonProperty("acceptsCashOnly")]
		public bool AcceptsCashOnly { get; set; }

		[JsonProperty("acceptsNfc", NullValueHandling = NullValueHandling.Ignore)]
		public bool? AcceptsNfc { get; set; }
	}
}
