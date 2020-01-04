// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using TelegramAPI.Getting_updates;
using TelegramBotAPI.Tests.Properties;

namespace TelegramBotAPI.Tests
{
    public sealed partial class GettingUpdatesTests
    {
        private readonly BotClient bot;
        private readonly long chat_id;
        private readonly Update sampleupdate;
        public GettingUpdatesTests()
        {
            var settings = JObject.Parse(Resources.test_settings);
            bot = new BotClient(settings["accesstoken"].ToObject<string>());
            chat_id = settings["chat_id"].ToObject<long>();
            sampleupdate = new Update()
            {
                Update_id = 0,
                Message = new TelegramAPI.Available_Types.Message()
                {
                    Message_id = 0,
                    Chat = new TelegramAPI.Available_Types.Chat() { Id = chat_id },
                    Text = "Message update"
                }
            };
        }
    }
}
