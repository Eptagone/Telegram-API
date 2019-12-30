// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using TelegramAPI.Available_Types;
using TelegramAPI.Available_Methods;
using Xunit;

namespace Telegram_API.Tests
{
    public class ForceReplyTests
    {
        [Fact]
        public void ForceReplyTest()
        {
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "ForceReply Test",
                    Reply_markup = new ForceReply()
                });
            Assert.NotNull(message);
        }
    }
}
