using Contracts.Domain;
using Contracts.Domain.Repositories;
using CQRS.Application.Commands.GoogleFeature;
using MediatR;
using Shared.DTOs.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Behaviors
{
	// This behavior is made for checking if returned places from google exist. If any place already exist in my database,
	// I will trigger update. Also if place is not registered/saved in my database, insert will be triggered.
	// Secured idempotency? I think yes...
	public class SaveToDatabaseBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
	{
		private readonly IRepositoryManager _repositoryManager;

        public SaveToDatabaseBehavior(IRepositoryManager repositoryManager)
        {
			_repositoryManager = repositoryManager;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			// If request is not SearchPlacesForLocationCommand then just continue with request handler.
			if (request is not SearchPlacesForLocationCommand) { await next.Invoke(); }

			// lets try  to add them
			var ids = await _repositoryManager.Place.GetPlacesIdsAsync();
			var response = await next.Invoke();
			if (response is GooglePlaceDTO googleResponse)
			{
				foreach (var place in googleResponse.Places)
				{
					if (ids.Contains(place.Id)) this._repositoryManager.Place.UpdatePlace(place);
					else this._repositoryManager.Place.CreatePlace(place);

				}
				await _repositoryManager.SaveAsync();
			}

			return response;
			
		}
	}
}
