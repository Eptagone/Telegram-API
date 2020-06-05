// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed class GetMeTest
    {
        [Fact]
        public void GetMe()
        {
            var user = Settings.Bot.GetMe();
            Assert.NotNull(user);
        }
    }
}
