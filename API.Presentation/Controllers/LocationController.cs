using Asp.Versioning;
using Contracts.Domain.Services;
using CQRS.Application.Commands.GoogleFeature;
using Entities.Domain.Google;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs.Google;

namespace PlacesAPI.Controllers
{
	[ApiController]
	[Route("api/v{v:apiVersion}/location")]
	public class LocationController : ControllerBase
	{
		private readonly ISender _sender;
        public LocationController(ISender sender)
        {
			_sender = sender;
        }

        [HttpPost("find", Name = "SearchGPSLocation")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetGPSLocations([FromBody]RequestPlaceDTO request)
		{
			var command = new SearchPlacesForLocationCommand(this.User, request);
			var result = await _sender.Send(command);

			return Ok(result);
		}

		[HttpGet("all", Name = "GetStoredLocations")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetStoredLocations()
		{
			var command = new GetAllStoredLocationsCommand(this.User);
			var result = await _sender.Send(command);
			return Ok(result);
		}

		[HttpGet("all/filter", Name = "GetStoredFilteredLocations")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetStoredFilteredLocations([FromQuery]Shared.RequestFeatures.PlaceParameters parameters)
		{
			return Ok();
		}
	}
}
