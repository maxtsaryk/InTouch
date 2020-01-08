using System.Collections.Generic;
using Aurochses.Data.EntityFrameworkCore;

namespace InTouch.Data.Chat.Entities
{
    public class PersonChatEntity : Entity<int>
    {
        public int PersonId { get; set; }
        public int ChatId { get; set; }
        public bool IsTyping { get; set; }
        public bool IsOwner { get; set; }

        public PersonEntity Person { get; set; }
        public ChatEntity Chat { get; set; }
        public IReadOnlyCollection<MessageEntity> Messages { get; set; }
    }
}
