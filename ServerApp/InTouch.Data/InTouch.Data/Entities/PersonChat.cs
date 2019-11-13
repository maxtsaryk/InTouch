using InTouch.Data.BaseEntities;

namespace InTouch.Data.Entities
{
    public class PersonChat : Entity
    {
        public bool IsTyping { get; set; }
        public int PersonId { get; set; }
        public int ChatId { get; set; }

        public Person Person { get; set; }
        public Chat Chat { get; set; }
    }
}
