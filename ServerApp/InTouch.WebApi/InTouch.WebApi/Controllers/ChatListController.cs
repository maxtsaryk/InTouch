using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InTouch.Business.Chat.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InTouch.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatListController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatListController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _chatService.GetListAsync();
                return Ok(new List<string> { "Chat 1", "Chat 2" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}