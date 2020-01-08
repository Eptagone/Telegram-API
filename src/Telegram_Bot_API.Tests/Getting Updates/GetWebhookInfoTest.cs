﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Getting_updates;
using Xunit;

namespace TelegramBotAPI.Tests
{
    [Trait("Update tasks", "Getting Updates")]
    public sealed partial class GettingUpdatesTests
    {
        [Fact]
        [Trait("Get Webhook info", "Getting Updates")]
        public void GetWebhookInfo()
        {
            var webhookInfo = bot.GetWebhookInfo();
            Assert.NotNull(webhookInfo);
        }
    }
}
