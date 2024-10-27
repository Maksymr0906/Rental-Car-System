using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Data.Models;
using System.Linq.Expressions;

namespace Rental_Car_System.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly RentalCarContext context;
        private readonly DbSet<TEntity> entities;

        public Repository(RentalCarContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<TEntity?> UpdateAsync(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity?> DeleteAsync(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                entities.Attach(entity);
            }

            entities.Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity?> GetByFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await entities.FirstOrDefaultAsync(filter);
        }
    }
}
