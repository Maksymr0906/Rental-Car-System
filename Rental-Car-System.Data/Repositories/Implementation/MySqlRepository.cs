using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories.Interface;
using System.Linq.Expressions;

namespace Rental_Car_System.Data.Repositories.Implementation
{
    public class MySqlRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly RentalCarContext context;
        private readonly DbSet<TEntity> entities;
        private static MySqlRepository<TEntity> instance;

        private MySqlRepository(RentalCarContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public static MySqlRepository<TEntity> GetInstance(RentalCarContext context)
        {
            if(instance == null)
            {
                instance = new MySqlRepository<TEntity>(context);
            }

            return instance;
        }
        public TEntity Create(TEntity entity)
        {
            entities.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public  IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }

        public TEntity? GetById(Guid id)
        {
            return entities.Find(id);
        }

        public TEntity? Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }

        public TEntity? Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                entities.Attach(entity);
            }

            entities.Remove(entity);
            context.SaveChanges();
            return entity;
        }

        public  TEntity? GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return entities.FirstOrDefault(filter);
        }
    }
}
