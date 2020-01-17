// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using Telegram.BotAPI.Tests.Properties;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    [Trait("Sending Messages", "SendingMessages")]
    public sealed partial class SendingMessages
    {
        private readonly BotClient bot;
        private readonly long chat_id;
        public SendingMessages()
        {
            var settings = JObject.Parse(Resources.test_settings);
            bot = new BotClient(settings["accesstoken"].ToObject<string>());
            chat_id = settings["chat_id"].ToObject<long>();
        }
    }
}
