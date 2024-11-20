using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace Rental_Car_System.Generic
{
	public interface IApplicationDbContext
	{
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
		EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
	}
}
