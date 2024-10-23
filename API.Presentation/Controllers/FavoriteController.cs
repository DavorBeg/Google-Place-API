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
			var result = _sender.Send(new GetUserFavoritePlaceCommand(this.User, placeId));
			return Ok("Authorized");
		}

		[HttpGet("all")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> GetFavoriteLocations()
		{
			var result = _sender.Send(new GetUserFavoritePlacesCommand(this.User));
			return Ok("Authorized");
		}

		[HttpPost("{placeDto}")]
		[Authorize]
		[MapToApiVersion(1)]
		public async Task<IActionResult> PostFavoriteLocation(FavoritePlaceForCreateDto placeDto)
		{
			var result = await _sender.Send(new CreateUserFavoritePlacesCommand(this.User, placeDto));
			return CreatedAtRoute("GetLocation", new { placeId = result });
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
