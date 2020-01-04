// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Methods;
using Xunit;

namespace TelegramBotAPI.Tests
{
    public sealed partial class SendingMessages
    {
        [Fact]
        [Trait("Reply", "Reply message")]
        public void ReplyToMessage()
        {
            var message = bot.SendMessage(chat_id, "Message to reply"); // Message to reply
            var reply = bot.SendMessage(chat_id, "Reply message", message.Message_id); //Reply
            Assert.NotNull(reply.Reply_to_message);
        }
        [Fact]
        [Trait("Reply alter", "Reply message")]
        public void ReplyToMessageAlter()
        {
            var message = bot.SendMessage(chat_id, "Message to reply"); // Message to reply
            var reply = bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = chat_id,
                    Text = "Reply message Alter",
                    Reply_to_message_id = message.Message_id
                }); //Reply Alter
            Assert.NotNull(reply.Reply_to_message);
        }
    }
}
