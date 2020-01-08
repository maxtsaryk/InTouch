using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Chat.Enums;

namespace InTouch.Data.Chat.Entities
{
    public class MessageEntity : Entity<int>
    {
        public int PersonChatId { get; set; }
        public string Content { get; set; }
        public long CreateTime { get; set; }
        public long UpdateTime { get; set; }
        public bool IsModified { get; set; }
        public MessageStatus Status { get; set; }

        public PersonChatEntity PersonChat { get; set; }
    }
}
