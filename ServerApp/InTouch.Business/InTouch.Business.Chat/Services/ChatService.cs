using System.Collections.Generic;
using System.Threading.Tasks;
using Aurochses.Data;
using AutoMapper;
using InTouch.Business.Chat.Dto;
using InTouch.Business.Chat.Interfaces;
using InTouch.Data.Chat;
using InTouch.Data.Chat.Entities;

namespace InTouch.Business.Chat.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChatService(IChatUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<ChatDto>> GetListAsync()
        {
            var chats = await _unitOfWork.ChatRepository.GetListAsync();
            return _mapper.Map<IList<ChatDto>>(chats);
        }

        public async Task<ChatDto> GetAsync()
        {
            var query = new QueryParameters<ChatEntity, int>
            {
                Filter = new FilterRule<ChatEntity, int>
                {
                    Expression = x => x.Id == 1
                }
            };
            var chat = await _unitOfWork.ChatRepository.GetAsync(query);
            return _mapper.Map<ChatDto>(chat);
        }
    }
}
