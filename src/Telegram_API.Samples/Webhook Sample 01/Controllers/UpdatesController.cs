﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelegramAPI.Available_Methods;
using TelegramAPI.Getting_updates;

namespace Webhook_Sample_01.Controllers
{
    [ApiController]
    [Route("updates")]
    public class UpdatesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if (update.Type == UpdateType.Message)
            {
                await TBot.Bot.SendMessageAsync(update.Message.Chat.Id, "Hello world!");
            }
            return Ok();
        }
    }
}