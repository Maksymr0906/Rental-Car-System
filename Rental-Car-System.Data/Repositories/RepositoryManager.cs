using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories.Interface;
using Rental_Car_System.Data.Repositories.Implementation;

namespace Rental_Car_System.Data.Repositories
{
    public static class RepositoryManager
    {
        public static IRepository<TEntity> GetRepo<TEntity>() where TEntity : Entity
        {
            return new MySqlRepository<TEntity>(new RentalCarContext());
        }
    }
}
