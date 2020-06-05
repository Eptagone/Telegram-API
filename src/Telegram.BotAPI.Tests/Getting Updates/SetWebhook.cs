using Telegram.BotAPI.Getting_updates;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class GettingUpdatesTests
    {
        [Fact]
        public void SetWebhook()
        {
            var ok = Settings.Bot.SetWebhook(new SetWebhookArgs
            {
                Url = "https://tapi.azurewebsites.net/tapi/"
            });
            Assert.True(ok);
        }
    }
}
