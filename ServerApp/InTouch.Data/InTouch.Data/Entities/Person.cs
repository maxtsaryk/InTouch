using System.Collections.Generic;
using InTouch.Data.BaseEntities;
using InTouch.Data.Enums;

namespace InTouch.Data.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public PersonStatus Status { get; set; }

        public IReadOnlyCollection<Message> Messages { get; set; }
        public IReadOnlyCollection<PersonChat> PersonChats { get; set; }
    }
}
