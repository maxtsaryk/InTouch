namespace InTouch.Business.Chat.Dto
{
    public class ChatDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string Photo { get; set; }
    }
}
