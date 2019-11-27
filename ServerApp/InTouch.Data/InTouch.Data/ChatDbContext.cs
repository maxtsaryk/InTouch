using InTouch.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data
{
    public class ChatDbContext : DbContext
    {
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonChat> PersonChats { get; set; }

        public ChatDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
