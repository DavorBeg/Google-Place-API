using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Domain.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> FindByCond(Expression<Func<T, bool>> condition, bool trackChanges); 
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
