using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data
{
    public class ChatUnitOfWork : UnitOfWork, IChatUnitOfWork
    {
        public ChatUnitOfWork(DbContext dbContext) : base(dbContext)
        {
        }

        protected override IRepository<TEntity, TType> GetRepository<TEntity, TType>()
        {
            var repository = base.GetRepository<TEntity, TType>();
            if (repository != null)
            {
                return repository;
            }

            RegisterRepository(new Repository<TEntity, TType>(DbContext));
            return base.GetRepository<TEntity, TType>();
        }

        public IRepository<Chat, int> ChatRepository => GetRepository<Chat, int>();

        public IRepository<Message, int> MessageRepository => GetRepository<Message, int>();

        public IRepository<Person, int> PersonRepository => GetRepository<Person, int>();
    }
}
