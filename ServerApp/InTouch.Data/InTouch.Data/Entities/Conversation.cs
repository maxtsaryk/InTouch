using System.Collections.Generic;
using InTouch.Data.BaseEntities;

namespace InTouch.Data.Entities
{
    public class Conversation : BaseEntity
    {
        public string Title { get; set; }
        public string Photo { get; set; }
        public int OwnerId { get; set; }

        public IReadOnlyCollection<PersonConversation> PersonConversations { get; set; }
    }
}
