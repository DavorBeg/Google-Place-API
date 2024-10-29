using AutoMapper;
using Contracts.Domain;
using Contracts.Domain.Services;
using CQRS.Application.Commands.FavoriteFeature;
using Exceptions.Domain;
using MediatR;
using Shared.DTOs.FavoriteFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Handlers.FavoriteFeature
{
	public class GetUserFavoritePlaceHandler : IRequestHandler<GetUserFavoritePlaceCommand, FavoritePlaceDto>
	{
		private readonly IRepositoryManager _repositoryManager;
		private readonly IMapper _mapper;
		private readonly IUserAccessor _userAccessor;

        public GetUserFavoritePlaceHandler(IRepositoryManager repositoryManager, IMapper mapper, IUserAccessor userAccessor)
        {
            _repositoryManager = repositoryManager;
			_mapper = mapper;
			_userAccessor = userAccessor;
        }
        public async Task<FavoritePlaceDto> Handle(GetUserFavoritePlaceCommand request, CancellationToken cancellationToken)
		{

			var userId = _userAccessor.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new UserNotFoundException();
			var result = await _repositoryManager.UserFavorites.GetFavoriteLocationForUserAsync(userId, request.placeId, false);
			if (result is null) throw new PlacesNotFoundException("Place with given id is not found");
			
			var mappedResult = _mapper.Map<FavoritePlaceDto>(result);
			return mappedResult;

		}
	}
}
