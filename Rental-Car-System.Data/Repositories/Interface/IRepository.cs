using Rental_Car_System.Data.Models;
using System.Linq.Expressions;

namespace Rental_Car_System.Data.Repositories.Interface
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Create(TEntity entity);
        TEntity? Update(TEntity entity);
        TEntity? Delete(TEntity entity);
        TEntity? GetById(Guid id);
        TEntity? GetByFilter(Expression<Func<TEntity, bool>> filter);
    }
}
