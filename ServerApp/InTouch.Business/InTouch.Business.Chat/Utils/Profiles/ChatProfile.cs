using AutoMapper;
using InTouch.Business.Chat.Dto;
using InTouch.Data.Chat.Entities;

namespace InTouch.Business.Chat.Utils.Profiles
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<ChatEntity, ChatDto>().ReverseMap();
        }
    }
}
