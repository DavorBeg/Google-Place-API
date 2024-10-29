using Exceptions.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Domain
{
	public class FavoritePlaceConflictException : ConflictException
	{
        public FavoritePlaceConflictException(string message = "Given place already exist as your favorite place.") : base(message)
        {
            
        }
    }
}
