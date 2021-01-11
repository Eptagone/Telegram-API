// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Tests.Properties;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class AdminChatActionsTest
    {
        [Fact]
        public void SetChatPhoto()
        {
            var setted = Settings.Bot.SetChatPhoto(Settings.ChatId, new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg"));
            Assert.True(setted);
        }
    }
}
