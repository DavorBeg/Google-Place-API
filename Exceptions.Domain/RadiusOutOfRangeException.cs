using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class RadiusOutOfRangeException : BadRequestException
	{
        public RadiusOutOfRangeException(string message = "radius is out of range. Must be range > 0 and range < 1000.") :
            base(message)
        {
            
        }
    }
}
