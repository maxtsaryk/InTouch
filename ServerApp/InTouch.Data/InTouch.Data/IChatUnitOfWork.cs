using Aurochses.Data;
using InTouch.Data.Entities;

namespace InTouch.Data
{
    public interface IChatUnitOfWork : IUnitOfWork
    {
        IRepository<Chat, int> ChatRepository { get; }
        IRepository<Message, int> MessageRepository { get; }
        IRepository<Person, int> PersonRepository { get; }
    }
}
