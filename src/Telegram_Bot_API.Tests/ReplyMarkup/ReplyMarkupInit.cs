// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using TelegramAPI;
using TelegramBotAPI.Tests.Properties;
using Xunit;
using Xunit.Abstractions;

namespace TelegramBotAPI.Tests
{
    [Trait("ReplyMarkup Options", "ReplyMarkup")]
    public sealed partial class ReplyMarkupTests
    {
        private readonly BotClient bot;
        private readonly long chat_id;
        private readonly ITestOutputHelper output;
        public ReplyMarkupTests(ITestOutputHelper outputHelper)
        {
            var settings = JObject.Parse(Resources.test_settings);
            bot = new BotClient(settings["accesstoken"].ToObject<string>());
            chat_id = settings["chat_id"].ToObject<long>();
            output = outputHelper;
        }
    }
}
