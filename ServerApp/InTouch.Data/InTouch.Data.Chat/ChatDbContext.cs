using InTouch.Data.Chat.Entities;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data.Chat
{
    public class ChatDbContext : DbContext
    {
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<PersonEntity> People { get; set; }
        public DbSet<PersonChatEntity> PersonChats { get; set; }

        public ChatDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
