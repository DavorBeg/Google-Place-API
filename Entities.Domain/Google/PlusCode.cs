using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public partial class PlusCode
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("globalCode")]
		public string GlobalCode { get; set; } = string.Empty;

		[JsonProperty("compoundCode")]
		public string CompoundCode { get; set; } = string.Empty;

		[JsonIgnore]
		public Guid? PlaceId { get; set; } 
	}
}
