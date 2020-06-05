// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Tests.Properties;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed class SendPhoto
    {
        [Fact]
        [Trait("SendPhoto", "Using file id")]
        public void Test00()
        {
            var message = Settings.Bot.SendPhoto(new SendPhotoArgs
            {
                Chat_id = Settings.PChatId,
                Photo = Settings.PhotoFileId
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendPhoto", "Upload photo")]
        public void Test01()
        {
            var message = Settings.Bot.SendPhoto(
                new SendPhotoArgs
                {
                    Chat_id = Settings.PChatId,
                    Photo = new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")
                });
            Assert.NotNull(message);
        }
    }
}
