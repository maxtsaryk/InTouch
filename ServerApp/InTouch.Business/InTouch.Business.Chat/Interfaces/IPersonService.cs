using System.Collections.Generic;
using System.Threading.Tasks;
using InTouch.Business.Chat.Dto;

namespace InTouch.Business.Chat.Interfaces
{
    public interface IPersonService
    {
        Task<IList<PersonDto>> GetListAsync();

        Task<PersonDto> GetAsync(int id);

        Task<PersonDto> CreateAsync(PersonDto model);

        PersonDto UpdateAsync(PersonDto model);

        Task<int> DeleteAsync(int id);
    }
}
