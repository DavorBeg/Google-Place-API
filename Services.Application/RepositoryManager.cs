using Contracts.Domain;
using Contracts.Domain.Repositories;
using Repository.Infrastructure;
using Repository.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Application
{
	public class RepositoryManager : IRepositoryManager
	{
		private readonly RepositoryContext _context;
		private readonly Lazy<IPlaceRepository> _placeRepository;
		private readonly Lazy<IUserRepository> _userRepository;

		public RepositoryManager(RepositoryContext context)
		{
			_context = context;
			_placeRepository = new Lazy<IPlaceRepository>(() => new PlaceRepository(context));
			_userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
		}

		public IPlaceRepository Place => _placeRepository.Value;
		public IUserRepository User => _userRepository.Value;

		public async Task SaveAsync() => await _context.SaveChangesAsync();
	}
}
