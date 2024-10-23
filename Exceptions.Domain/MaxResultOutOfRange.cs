using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class MaxResultOutOfRange : BadRequestException
	{
        public MaxResultOutOfRange(string message = "maxResultCount is out of range. Must be > 0 and < 1000") : 
            base(message)
        {
            
        }
    }
}
