using Asp.Versioning;
using Contracts.Domain.Services;
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
		// ONLY TEMP, FOR DELETE LATER AND MOVE TO MEDIATR
		private readonly IGoogleService _googleService;
        public LocationController(IGoogleService googleService)
        {
			_googleService = googleService;
        }

        [HttpPost("find", Name = "SearchGPSLocation")]
		//[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetGPSLocations([FromBody]RequestPlaceDTO request)
		{
			var result = await _googleService.SearchLocation(request, "21ddawm11nff_231xdkv");
			return Ok(result);
		}

		[HttpGet("all", Name = "GetStoredLocations")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetGPSLocations()
		{
			return Ok();
		}

		[HttpGet("all/filter", Name = "GetStoredLocationsByParameters")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetGPSLocations([FromQuery]Shared.RequestFeatures.PlaceParameters parameters)
		{
			return Ok();
		}
	}
}
