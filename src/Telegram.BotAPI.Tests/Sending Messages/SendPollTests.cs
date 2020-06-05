// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Updating_messages;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class SendingMessages
    {
        [Fact]
        public void SendAndStopPoll()
        {
            var message = Settings.Bot.SendPoll(new SendPollArgs
            {
                Chat_id = Settings.PChatId,
                Question = "¿5 + 6?",
                Options = new string[] { "5", "-1", "6", "11" }
            }); //New poll
            Assert.NotNull(message);
            var stopped = Settings.Bot.StopPoll(Settings.PChatId, message.Message_id); //Stoppoll
        }
    }
}
