using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace InTouch.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatListController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new List<string> { "Chat 1", "Chat 2" });
        }
    }
}