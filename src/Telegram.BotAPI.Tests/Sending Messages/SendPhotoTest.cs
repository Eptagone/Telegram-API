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
            var message = Settings.Bot.SendPhoto(new SendPhotoArgs
            {
                Chat_id = Settings.PChatId,
                Photo = "AgACAgEAAxkBAAM4XjI95Alvnw0bHXMYQzn0PrggqbUAAkOoMRtUu5BFSNvo0gL4nS1f_GsGAAQBAAMCAANtAAOpRgIAARgE"
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload photo", "SendPhoto")]
        public void SendPhotoFromUploadFile()
        {
            var message = Settings.Bot.SendPhoto(
                new SendPhotoArgs
                {
                    Chat_id = Settings.PChatId,
                    Photo = new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")
                });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Photo from telegram servers", "SendPhotoAsync")]
        public async void SendPhotoFromTelegramServersAsyncTest()
        {
            var message = await Settings.Bot.SendPhotoAsync(new SendPhotoArgs
            {
                Chat_id = Settings.PChatId,
                Photo = "AgACAgEAAxkBAAM4XjI95Alvnw0bHXMYQzn0PrggqbUAAkOoMRtUu5BFSNvo0gL4nS1f_GsGAAQBAAMCAANtAAOpRgIAARgE"
            }).ConfigureAwait(true);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload photo", "SendPhotoAsync")]
        public async void SendPhotoFromUploadFileAsync()
        {
            var message = await Settings.Bot.SendPhotoAsync(
                new SendPhotoArgs
                {
                    Chat_id = Settings.PChatId,
                    Photo = new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")
                }).ConfigureAwait(true);
            Assert.NotNull(message);
        }
    }
}
