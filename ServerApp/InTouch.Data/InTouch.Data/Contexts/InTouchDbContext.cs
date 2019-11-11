using InTouch.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data.Contexts
{
    public class InTouchDbContext: DbContext
    {
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonChat> PersonChats { get; set; }

        public InTouchDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
