using System.Collections.Generic;
using Aurochses.Data.EntityFrameworkCore;
using InTouch.Data.Chat.Enums;

namespace InTouch.Data.Chat.Entities
{
    public class PersonEntity : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public PersonStatus Status { get; set; }

        public IReadOnlyCollection<PersonChatEntity> PersonChats { get; set; }
    }
}
