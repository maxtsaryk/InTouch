using System.Collections.Generic;
using Aurochses.Data.EntityFrameworkCore;

namespace InTouch.Data.Entities
{
    public class Chat : Entity<int>
    {
        public string Title { get; set; }
        public string Photo { get; set; }
        public int OwnerId { get; set; }

        public IReadOnlyCollection<PersonChat> PersonChats { get; set; }
    }
}
