// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using TelegramBotAPI.Tests.Properties;
using Xunit;

namespace TelegramBotAPI.Tests
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
