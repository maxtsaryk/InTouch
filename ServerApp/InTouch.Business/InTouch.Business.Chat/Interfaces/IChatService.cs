using System.Collections.Generic;
using System.Threading.Tasks;
using InTouch.Business.Chat.Dto;

namespace InTouch.Business.Chat.Interfaces
{
    public interface IChatService
    {
        Task<IList<ChatDto>> GetListAsync();

        Task<ChatDto> GetAsync();
    }
}
