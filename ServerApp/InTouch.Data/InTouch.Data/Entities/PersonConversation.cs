using InTouch.Data.BaseEntities;

namespace InTouch.Data.Entities
{
    public class PersonConversation : BaseEntity
    {
        public bool IsTyping { get; set; }
        public int PersonId { get; set; }
        public int ConversationId { get; set; }

        public Person Person { get; set; }
        public Conversation Conversation { get; set; }
    }
}
