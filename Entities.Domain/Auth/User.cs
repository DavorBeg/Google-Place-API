using Entities.Domain.Google;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Auth
{
    public class User : IdentityUser
    {
        public string? UserAPIKey { get; set; }
        public virtual IEnumerable<Place> FavoritePlaces { get; set; } = Enumerable.Empty<Place>();
    }
}
