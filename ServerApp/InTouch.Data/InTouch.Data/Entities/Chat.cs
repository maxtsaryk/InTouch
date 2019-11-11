using System.Collections.Generic;
using InTouch.Data.BaseEntities;

namespace InTouch.Data.Entities
{
    public class Chat : BaseEntity
    {
        public string Title { get; set; }
        public string Photo { get; set; }
        public int OwnerId { get; set; }

        public IReadOnlyCollection<PersonChat> PersonChats { get; set; }
    }
}
