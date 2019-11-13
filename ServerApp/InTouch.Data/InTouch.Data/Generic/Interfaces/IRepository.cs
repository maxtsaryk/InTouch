using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using InTouch.Data.BaseEntities;

namespace InTouch.Data.Generic.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        Task<IList<TEntity>> GetList(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>> orderBy);
        Task<TEntity> Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
