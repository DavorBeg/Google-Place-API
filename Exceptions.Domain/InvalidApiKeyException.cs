using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class InvalidApiKeyException : BadRequestException
	{
        public InvalidApiKeyException(string message = "Provided api key is not valid!") : base(message) { }
    }
}
