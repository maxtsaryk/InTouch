using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Enums;

namespace InTouch.Data.Entities
{
    public class Message : Entity<int>
    {
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public string Content { get; set; }
        public long CreateTime { get; set; }
        public bool IsModified { get; set; }
        public MessageStatus Status { get; set; }

        public Person Sender { get; set; }
        public Chat Chat { get; set; }
    }
}
