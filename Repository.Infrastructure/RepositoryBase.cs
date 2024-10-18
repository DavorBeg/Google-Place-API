using Contracts.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure
{
	public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{

		protected RepositoryContext _context;

		protected RepositoryBase(RepositoryContext context)
		{
			_context = context;
		}

		public void Create(T entity)
		{
			_context.Set<T>().Add(entity);
		}

		public void Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
		}
		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
		}

		public IQueryable<T> FindByCond(Expression<Func<T, bool>> condition, bool trackChanges)
		{
			return trackChanges ? _context.Set<T>().Where(condition) : _context.Set<T>().Where(condition).AsNoTracking();
		}

		public IQueryable<T> GetAll(bool trackChanges)
		{
			return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
		}

	}
}
