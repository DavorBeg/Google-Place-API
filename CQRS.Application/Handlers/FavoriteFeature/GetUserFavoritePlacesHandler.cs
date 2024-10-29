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
	public class GetUserFavoritePlacesHandler : IRequestHandler<GetUserFavoritePlacesCommand, IEnumerable<FavoritePlaceDto>>
	{
		private readonly IRepositoryManager _repositoryManager;
		private readonly IUserAccessor _userAccessor;
		private readonly IMapper _mapper;

		public GetUserFavoritePlacesHandler(IRepositoryManager repositoryManager, IMapper mapper, IUserAccessor userAccessor)
        {
			_repositoryManager = repositoryManager;
			_mapper = mapper;
			_userAccessor = userAccessor;
		}
        public async Task<IEnumerable<FavoritePlaceDto>> Handle(GetUserFavoritePlacesCommand request, CancellationToken cancellationToken)
		{
			var userId = _userAccessor.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new UserNotFoundException();
			var result = await _repositoryManager.UserFavorites.GetAllFavoritePlacesForUserAsync(userId, false);
			var mappedResult = _mapper.Map<IEnumerable<FavoritePlaceDto>>(result);

			return mappedResult;
		}
	}
}
