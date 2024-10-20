using Entities.Domain.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Google
{
	public record RequestPlaceDTO(IEnumerable<string> includedTypes, int maxResultCount, Circle circle);
}