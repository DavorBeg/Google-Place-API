using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain.Abstraction
{
	public class InternalServerError : Exception
	{
		protected InternalServerError(string message) : base(message)
		{

		}
	}
}
