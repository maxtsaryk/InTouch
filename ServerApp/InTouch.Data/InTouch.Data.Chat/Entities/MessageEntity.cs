using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Chat.Enums;

namespace InTouch.Data.Chat.Entities
{
    public class MessageEntity : Entity<int>
    {
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public string Content { get; set; }
        public long CreateTime { get; set; }
        public bool IsModified { get; set; }
        public MessageStatus Status { get; set; }

        public PersonEntity Sender { get; set; }
        public Data.Chat.Entities.ChatEntity Chat { get; set; }
    }
}
