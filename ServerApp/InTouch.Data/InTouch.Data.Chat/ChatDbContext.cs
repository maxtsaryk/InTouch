using InTouch.Data.Chat.Configurations;
using InTouch.Data.Chat.Entities;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data.Chat
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChatConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }

        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<PersonEntity> People { get; set; }
        public DbSet<PersonChatEntity> PersonChats { get; set; }
    }
}
