using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using InTouch.Data.BaseEntities;
using InTouch.Data.Generic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data.Generic
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return await Query(predicate).FirstOrDefaultAsync();
        }

        public async Task<IList<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> orderBy)
        {
            return await Query(predicate, orderBy).ToListAsync();
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            return (await _dbSet.AddAsync(entity)).Entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbSet.Remove(entity);
        }

        private IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, object>> orderBy = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = query.OrderBy(orderBy);
            }

            return query;
        }
    }
}
