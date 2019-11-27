using Aurochses.Data;
using InTouch.Data.Chat.Entities;

namespace InTouch.Data.Chat
{
    public interface IChatUnitOfWork : IUnitOfWork
    {
        IRepository<ChatEntity, int> ChatRepository { get; }
        IRepository<MessageEntity, int> MessageRepository { get; }
        IRepository<PersonEntity, int> PersonRepository { get; }
    }
}
