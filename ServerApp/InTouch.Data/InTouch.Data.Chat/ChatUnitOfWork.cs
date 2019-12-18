using Aurochses.Data;
using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Chat.Entities;

namespace InTouch.Data.Chat
{
    public class ChatUnitOfWork : UnitOfWork, IChatUnitOfWork
    {
        public ChatUnitOfWork(ChatDbContext dbContext) : base(dbContext)
        {
            RegisterRepository(new Repository<ChatEntity, int>(DbContext));
            RegisterRepository(new Repository<MessageEntity, int>(DbContext));
            RegisterRepository(new Repository<PersonEntity, int>(DbContext));
        }

       public IRepository<ChatEntity, int> ChatRepository => GetRepository<ChatEntity, int>();

        public IRepository<MessageEntity, int> MessageRepository => GetRepository<MessageEntity, int>();

        public IRepository<PersonEntity, int> PersonRepository => GetRepository<PersonEntity, int>();
    }
}
