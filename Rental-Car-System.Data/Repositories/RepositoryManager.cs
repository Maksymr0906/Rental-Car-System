using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories.Interface;
using Rental_Car_System.Data.Repositories.Implementation;

namespace Rental_Car_System.Data.Repositories
{
    public static class RepositoryManager
    {
        private static readonly RentalCarContext context;
        
        static RepositoryManager()
        {
            context = new RentalCarContext();
        }
        public static IRepository<TEntity> GetRepo<TEntity>() where TEntity : Entity
        {
            var repository = MySqlRepository<TEntity>.GetInstance(context);
            return repository;
        }
    }
}
