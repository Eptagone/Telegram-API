// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using Telegram.BotAPI.Tests.Properties;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class AdminChatActionsTest
    {
        private readonly BotClient bot;
        private readonly long chat_id;
        public AdminChatActionsTest()
        {
            var settings = JObject.Parse(Resources.test_settings);
            bot = new BotClient(settings["accesstoken"].ToObject<string>());
            chat_id = settings["chat_id"].ToObject<long>();
        }
    }
}
