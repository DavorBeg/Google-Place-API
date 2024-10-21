﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Authentication
{
	public record UserForLoginDto
	{
		[Required(ErrorMessage = "Username is required for login.")]
		public string username { get; set; } = null!;

		[Required(ErrorMessage = "Password is required for login.")]
		public string password { get; set; } = null!;
	}
}
