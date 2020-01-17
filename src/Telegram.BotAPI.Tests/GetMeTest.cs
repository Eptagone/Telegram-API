// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Tests.Properties;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed class GetMeTest
    {
        private readonly BotClient bot;
        public GetMeTest()
        {
            var settings = JObject.Parse(Resources.test_settings);
            bot = new BotClient(settings["accesstoken"].ToObject<string>());
        }
        [Fact]
        public void GetMe()
        {
            var user = bot.GetMe();
            Assert.NotNull(user);
        }
    }
}
