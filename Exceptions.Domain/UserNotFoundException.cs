using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class UserNotFoundException : NotFoundException
	{
        public UserNotFoundException(string message = "User is not found!") : base(message)
        {
            
        }
    }
}
