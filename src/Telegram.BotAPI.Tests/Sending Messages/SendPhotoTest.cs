// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Telegram.BotAPI.Tests.Properties;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class SendingMessages
    {
        [Fact]
        [Trait("Photo from telegram servers", "SendPhoto")]
        public void SendPhotoFromTelegramServersTest()
        {
            var message = bot.SendPhoto(new SendPhotoArgs
            {
                Chat_id = chat_id,
                Photo = "AgADAQADSKgxGxofwERLH1hy62zAcp3vawYABAEAAwIAA20AA2YPAgABFgQ"
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload photo", "SendPhoto")]
        public void SendPhotoFromUploadFile()
        {
            var message = bot.SendPhoto(
                new SendPhotoArgs
                {
                    Chat_id = chat_id,
                    Photo = new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")
                });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Photo from telegram servers", "SendPhotoAsync")]
        public async void SendPhotoFromTelegramServersAsyncTest()
        {
            var message = await bot.SendPhotoAsync(new SendPhotoArgs
            {
                Chat_id = chat_id,
                Photo = "AgADAQADSKgxGxofwERLH1hy62zAcp3vawYABAEAAwIAA20AA2YPAgABFgQ"
            }).ConfigureAwait(true);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload photo", "SendPhotoAsync")]
        public async void SendPhotoFromUploadFileAsync()
        {
            var message = await bot.SendPhotoAsync(
                new SendPhotoArgs
                {
                    Chat_id = chat_id,
                    Photo = new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")
                }).ConfigureAwait(true);
            Assert.NotNull(message);
        }
    }
}
