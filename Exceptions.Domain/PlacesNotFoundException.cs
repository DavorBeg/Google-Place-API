using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class PlacesNotFoundException : NotFoundException
	{
        public PlacesNotFoundException(string message = "Google have not found any places in given location and radius")
            :base(message)
        {
            
        }
    }
}
