using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InTouch.Data.BaseEntities;
using InTouch.Data.Generic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDictionary<Type, object> _repositories;
        private bool _isDisposed;

        public UnitOfWork(DbContext dbContext)
        {
            DbContext = dbContext;
            _repositories = new Dictionary<Type, object>();
        }

        protected DbContext DbContext { get; }

        protected void RegisterRepository<TEntity>(IRepository<TEntity> repository) where TEntity : BaseEntity
        {
            this._repositories[typeof(TEntity)] = (object)repository;
        }

        protected virtual IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            return (IRepository<TEntity>)this._repositories[typeof(TEntity)];
        }

        public async Task SaveChanges()
        {
            await DbContext.SaveChangesAsync();
        }

        public void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }

            if (disposing)
            {
                DbContext.Dispose();
            }

            _isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
