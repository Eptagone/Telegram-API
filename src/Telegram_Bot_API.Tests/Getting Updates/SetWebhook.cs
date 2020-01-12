using System;
using System.Collections.Generic;
using System.Text;
using TelegramAPI.Getting_updates;
using Xunit;

namespace TelegramBotAPI.Tests
{
    public sealed partial class GettingUpdatesTests
    {
        [Fact]
        public void SetWebhook()
        {
            var ok = bot.SetWebhook(new SetWebhookArgs {
                Url = "https://tapi.azurewebsites.net/tapi/"
            });
            Assert.True(ok);
        }
    }
}
