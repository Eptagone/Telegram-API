// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Getting_updates;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    [Trait("Update tasks", "Getting Updates")]
    public sealed partial class GettingUpdatesTests
    {
        [Fact]
        [Trait("Get Webhook info", "Getting Updates")]
        public void GetWebhookInfo()
        {
            var webhookInfo = Settings.Bot.GetWebhookInfo();
            Assert.NotNull(webhookInfo);
        }
    }
}
