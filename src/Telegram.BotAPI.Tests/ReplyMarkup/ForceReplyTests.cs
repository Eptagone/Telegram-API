// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class ReplyMarkupTests
    {
        [Fact]
        [Trait("ForceReply", "ForceReply")]
        public void ForceReplyTest()
        {
            var message = Settings.Bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Settings.PChatId,
                    Text = "ForceReply Test",
                    Reply_markup = new ForceReply()
                });
            Assert.NotNull(message);
        }
    }
}
