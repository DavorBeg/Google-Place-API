using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain.Abstraction
{
	public abstract class ConflictException : Exception
	{
        public ConflictException(string message) : base(message)
        {
            
        }
    }
}
