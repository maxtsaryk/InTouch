using AutoMapper;
using InTouch.Business.Chat.Dto;
using InTouch.Data.Chat.Entities;

namespace InTouch.Business.Chat.Utils.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonEntity, PersonDto>();
            CreateMap<PersonDto, PersonEntity>();
        }
    }
}
