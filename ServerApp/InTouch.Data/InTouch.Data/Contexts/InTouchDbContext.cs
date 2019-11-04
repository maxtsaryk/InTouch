using InTouch.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InTouch.Data
{
    public class InTouchDbContext: DbContext
    {
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonConversation> PersonConversations { get; set; }

        public InTouchDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
