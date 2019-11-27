using Aurochses.Data.EntityFrameworkCore;

namespace InTouch.Data.Chat.Entities
{
    public class PersonChatEntity : Entity<int>
    {
        public bool IsTyping { get; set; }
        public int PersonId { get; set; }
        public int ChatId { get; set; }

        public PersonEntity Person { get; set; }
        public ChatEntity Chat { get; set; }
    }
}
