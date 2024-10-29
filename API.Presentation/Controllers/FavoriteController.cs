using Asp.Versioning;
using CQRS.Application.Commands;
using CQRS.Application.Commands.FavoriteFeature;
using CQRS.Application.Notifications.FavoriteFeature;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs.Authentication;
using Shared.DTOs.FavoriteFeature;

namespace PlacesAPI.Controllers
{
	[ApiController]
	[Route("api/v{v:apiVersion}/favorite")]
	public class FavoriteController : ControllerBase
	{

		private readonly ISender _sender;
		private readonly IPublisher _publisher;

		public FavoriteController(ISender sender, IPublisher publisher)
        {
			this._sender = sender;
			this._publisher = publisher;
		}

        [HttpGet("{placeId}", Name = "GetLocation")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetFavoriteLocation(string placeId)
		{
			var result = await _sender.Send(new GetUserFavoritePlaceCommand(placeId));
			return Ok(result);
		}

		[HttpGet("all")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetFavoriteLocations()
		{
			var result = await _sender.Send(new GetUserFavoritePlacesCommand());
			return Ok(result);
		}

		[HttpPost("{placeId}")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> PostFavoriteLocation(string placeId)
		{
			await _sender.Send(new CreateUserFavoritePlaceCommand(placeId));
			return CreatedAtRoute("GetLocation", routeValues: new { placeId }, new { Id = placeId });
		}

		[HttpDelete("{placeDto}")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> RemoveFavoriteLocation(string placeDto)
		{
			await _publisher.Publish(new UserFavoritePlaceDeletedNotification(placeDto));
			return Ok("Authorized");
		}
	}
}
