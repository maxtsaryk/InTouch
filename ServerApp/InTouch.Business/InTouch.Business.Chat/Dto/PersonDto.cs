using InTouch.Business.Chat.Enums;

namespace InTouch.Business.Chat.Dto
{
    public class PersonDto : BaseDto<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public PersonStatus Status { get; set; }
    }
}
