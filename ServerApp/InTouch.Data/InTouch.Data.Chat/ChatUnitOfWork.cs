using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Chat.Entities;

namespace InTouch.Data.Chat
{
    public class ChatUnitOfWork : UnitOfWork, IChatUnitOfWork
    {
        public ChatUnitOfWork(ChatDbContext dbContext) : base(dbContext)
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

        public IRepository<ChatEntity, int> ChatRepository => GetRepository<ChatEntity, int>();

        public IRepository<MessageEntity, int> MessageRepository => GetRepository<MessageEntity, int>();

        public IRepository<PersonEntity, int> PersonRepository => GetRepository<PersonEntity, int>();
    }
}
