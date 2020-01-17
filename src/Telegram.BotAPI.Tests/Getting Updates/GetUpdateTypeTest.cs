// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Getting_updates;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class GettingUpdatesTests
    {
        [Fact]
        public void GetUpdateTypeTest()
        {
            var updatetype = sampleupdate.Type;
            Assert.False(updatetype == UpdateType.Unknown);
        }
    }
}
