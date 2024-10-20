using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class Period
	{
		[Key]
		[JsonIgnore]
		public Guid Id { get; set; } = Guid.NewGuid();

		[JsonProperty("open")]
		public virtual Close? Open { get; set; }
		[JsonIgnore]
		public Guid? OpenId { get; set; }

		[JsonProperty("close")]
		public virtual Close? Close { get; set; }
		[JsonIgnore]
		public Guid? CloseId { get; set; }

		[JsonIgnore]
		public Guid CurrentOpeningHoursId { get; set; }
	}
}
