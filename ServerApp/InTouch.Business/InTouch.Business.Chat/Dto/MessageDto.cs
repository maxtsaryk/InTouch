using InTouch.Business.Chat.Enums;

namespace InTouch.Business.Chat.Dto
{
    public class MessageDto : BaseDto<int>
    {
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public string Content { get; set; }
        public long CreateTime { get; set; }
        public bool IsModified { get; set; }
        public MessageStatus Status { get; set; }
    }
}
