using System.Threading.Tasks;
using InTouch.Business.Chat.Dto;
using InTouch.Business.Chat.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InTouch.WebApi.Controllers
{
    [Route("api/v1/chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet("list/{personId}")]
        public async Task<ActionResult> GetListAsync(int personId)
        {
            var result = await _chatService.GetListAsync(personId);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var result = await _chatService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(int personId, ChatDto model)
        {
            var result = await _chatService.CreateAsync(personId, model);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult UpdateAsync(ChatDto model)
        {
            var result = _chatService.UpdateAsync(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _chatService.DeleteAsync(id);
            return Ok(result);
        }
    }
}