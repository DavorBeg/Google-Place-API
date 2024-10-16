using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class PasswordNotMatchedException : BadRequestException
	{
		public PasswordNotMatchedException() : base("Inserted passwords are not same! Check your password and repeat password.") { }

    }
}
