// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Methods;
using TelegramAPI.Available_Types;
using Xunit;

namespace TelegramBotAPI.Tests
{
    public sealed partial class ReplyMarkupTests
    {
        [Fact]
        [Trait("ForceReply", "ForceReply")]
        public void ForceReplyTest()
        {
            var message = bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = chat_id,
                    Text = "ForceReply Test",
                    Reply_markup = new ForceReply()
                });
            Assert.NotNull(message);
        }
    }
}
