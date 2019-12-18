using AutoMapper;
using InTouch.Business.Chat.Dto;
using InTouch.Data.Chat.Entities;

namespace InTouch.Business.Chat.Utils.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<MessageEntity, MessageDto>().ReverseMap();
        }
    }
}
