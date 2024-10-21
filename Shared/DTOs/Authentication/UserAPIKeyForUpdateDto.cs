using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Authentication
{
    public record UserAPIKeyForUpdateDto
    {
        [Required(ErrorMessage = "Please insert your new api key.")]
		[RegularExpression(@"^AIza[0-9A-Za-z_-]{35}$", ErrorMessage = "Invalid Google API Key format.")]
		public string key { get; init; } = null!;
    }
}
