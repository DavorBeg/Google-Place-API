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
		[JsonIgnore]
		[Key]
		public Guid Id { get; set; }

		[JsonProperty("open")]
		public Close? Open { get; set; }

		[JsonProperty("close")]
		public Close? Close { get; set; }
	}
}
