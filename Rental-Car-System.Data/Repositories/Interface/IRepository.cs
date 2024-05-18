using Rental_Car_System.Data.Models;
using System.Linq.Expressions;

namespace Rental_Car_System.Data.Repositories.Interface
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity?> UpdateAsync(TEntity entity);
        Task<TEntity?> DeleteAsync(TEntity entity);
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<TEntity?> GetByFilterAsync(Expression<Func<TEntity, bool>> filter);
    }
}
