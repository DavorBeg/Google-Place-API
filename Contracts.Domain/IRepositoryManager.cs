﻿using Contracts.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain
{
	public interface IRepositoryManager
	{
		IPlaceRepository Place { get; }
		IUserRepository User { get; }
		IFavoriteRepository UserFavorites { get; }

		Task SaveAsync();
	}
}
