using System.Collections.Generic;
using Aurochses.Data.EntityFrameworkCore;

namespace InTouch.Data.Chat.Entities
{
    public class ChatEntity : Entity<int>
    {
        public string Title { get; set; }
        public string Photo { get; set; }
        public int OwnerId { get; set; }

        public PersonEntity Owner { get; set; }
        public IReadOnlyCollection<PersonChatEntity> PersonChats { get; set; }
    }
}
