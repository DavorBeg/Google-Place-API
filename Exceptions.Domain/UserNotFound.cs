using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class UserNotFound : NotFoundException
	{
		public UserNotFound() : base("Given user does not exist") { }
    }
}
