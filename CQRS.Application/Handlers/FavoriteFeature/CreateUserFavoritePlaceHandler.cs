using AutoMapper;
using Contracts.Domain.Services;
using Contracts.Domain;
using CQRS.Application.Commands.FavoriteFeature;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions.Domain;
using System.Security.Claims;

namespace CQRS.Application.Handlers.FavoriteFeature
{
	internal class CreateUserFavoritePlaceHandler : IRequestHandler<CreateUserFavoritePlaceCommand>
	{
		private readonly IRepositoryManager _repositoryManager;
		private readonly IUserAccessor _userAccessor;
        public CreateUserFavoritePlaceHandler(IRepositoryManager repositoryManager, IUserAccessor userAccessor)
        {
			_repositoryManager = repositoryManager;
			_userAccessor = userAccessor;
        }

        public async Task Handle(CreateUserFavoritePlaceCommand request, CancellationToken cancellationToken)
		{
			var userId = _userAccessor.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new UserNotFoundException();
			var places = await _repositoryManager.Place.GetPlacesIdsAsync();
			if (places.Contains(request.placeId) == false) throw new PlacesNotFoundException($"Place with id: {request.placeId} was not found.");

			await _repositoryManager.UserFavorites.CreateFavoriteLocationForUserAsync(userId, request.placeId);
			await _repositoryManager.SaveAsync();

		}
	}
}
