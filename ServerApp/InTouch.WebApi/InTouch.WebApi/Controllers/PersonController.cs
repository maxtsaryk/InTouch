using System.Threading.Tasks;
using InTouch.Business.Chat.Dto;
using InTouch.Business.Chat.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InTouch.WebApi.Controllers
{
    [Route("api/v1/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("list")]
        public async Task<ActionResult> GetListAsync()
        {
            var result = await _personService.GetListAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var result = await _personService.GetAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(PersonDto model)
        {
            var result = await _personService.CreateAsync(model);

            return Ok(result);
        }

        [HttpPut]
        public ActionResult UpdateAsync(PersonDto model)
        {
            var result = _personService.UpdateAsync(model);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _personService.DeleteAsync(id);

            return Ok(result);
        }
    }
}