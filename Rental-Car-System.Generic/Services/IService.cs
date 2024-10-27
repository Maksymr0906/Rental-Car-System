using Rental_Car_System.Generic.Models;

namespace Rental_Car_System.Generic.Services
{
    public interface IService<TEntity> where TEntity : Entity
	{
        Task Add(TEntity entity);
        Task<TEntity> GetAll();
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);
    }
}
