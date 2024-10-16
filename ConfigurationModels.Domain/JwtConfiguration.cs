﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationModels.Domain
{
	public class JwtConfiguration
	{
		public string Section { get; set; } = "JwtSettings";

		public string? ValidIssuer { get; set; }
		public string? ValidAudience { get; set; }
		public string? Expires { get; set; }
		public string? Secret { get; set; }

		public override string ToString() => Section;
	}
}
