using Rental_Car_System.Generic.Models;
using Rental_Car_System.Generic.Repositories;

namespace Rental_Car_System.Data.Repositories
{
    public static class RepositoryManager
    {
        public static IRepository<TEntity> GetRepo<TEntity>() where TEntity : Entity
        {
            return new Repository<TEntity>(new RentalCarContext());
        }
    }
}
