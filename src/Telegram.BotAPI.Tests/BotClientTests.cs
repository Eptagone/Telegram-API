// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using Telegram.BotAPI.Tests.Properties;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public class BotClientInitTests
    {
        private readonly string token;
        public BotClientInitTests() => token = JObject.Parse(Resources.test_settings)["accesstoken"].ToObject<string>();
        [Fact]
        public void NewBotClientTest()
        {
            var bot = new BotClient(token);
            Assert.NotNull(bot);
        }
    }
}
