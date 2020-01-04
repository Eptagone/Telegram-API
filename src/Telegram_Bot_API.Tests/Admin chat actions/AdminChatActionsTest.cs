// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Methods;
using TelegramAPI.Available_Types;
using TelegramBotAPI.Tests.Properties;
using Xunit;

namespace TelegramBotAPI.Tests
{
    public sealed partial class AdminChatActionsTest
    {
        [Fact]
        public void SetChatPhoto()
        {
            var setted = bot.SetChatPhoto(chat_id, new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg"));
            Assert.True(setted);
        }
    }
}
