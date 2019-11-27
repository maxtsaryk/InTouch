using Aurochses.Data.EntityFrameworkCore;

namespace InTouch.Data.Entities
{
    public class PersonChat : Entity<int>
    {
        public bool IsTyping { get; set; }
        public int PersonId { get; set; }
        public int ChatId { get; set; }

        public Person Person { get; set; }
        public Chat Chat { get; set; }
    }
}
