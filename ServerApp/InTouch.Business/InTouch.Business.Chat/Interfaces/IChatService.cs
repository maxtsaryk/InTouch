using System.Collections.Generic;
using System.Threading.Tasks;
using InTouch.Business.Chat.Dto;

namespace InTouch.Business.Chat.Interfaces
{
    public interface IChatService
    {
        Task<IList<ChatDto>> GetListAsync(int personId);

        Task<ChatDto> GetAsync(int id);

        Task<ChatDto> CreateAsync(int currentPersonId, ChatDto model);

        ChatDto UpdateAsync(ChatDto model);

        Task<int> DeleteAsync(int id);
    }
}
