// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class SendingMessages
    {
        [Fact]
        [Trait("Reply", "Reply message")]
        public void ReplyToMessage()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Message to reply"); // Message to reply
            var reply = Settings.Bot.SendMessage(Settings.PChatId, "Reply message", reply_to_message_id: message.Message_id); //Reply
            Assert.NotNull(reply.Reply_to_message);
        }
        [Fact]
        [Trait("Reply alter", "Reply message")]
        public void ReplyToMessageAlter()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Message to reply"); // Message to reply
            var reply = Settings.Bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Settings.PChatId,
                    Text = "Reply message Alter",
                    Reply_to_message_id = message.Message_id
                }); //Reply Alter
            Assert.NotNull(reply.Reply_to_message);
        }
    }
}
