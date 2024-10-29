using MediatR;
using Shared.DTOs.Google;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Commands.GoogleFeature
{
	public record GetStoredFilteredLocationsCommand(PlaceParameters parameters) : IRequest<IEnumerable<PlaceDto>>;
}
