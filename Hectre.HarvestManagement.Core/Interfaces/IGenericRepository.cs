using System.Linq.Expressions;

namespace Hectre.HarvestManagement.Core.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class

    {
        public Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        public Task<TEntity> GetByIDAsync(object id);
        public Task InsertAsync(TEntity entity);
        public Task DeleteAsync(object id);
        public void Delete(TEntity entityToDelete);
        public void Update(TEntity entityToUpdate);
    }
}

