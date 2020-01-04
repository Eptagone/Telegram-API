// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Methods;
using TelegramAPI.Available_Types;
using TelegramBotAPI.Tests.Properties;
using Xunit;

namespace TelegramBotAPI.Tests
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
                Photo = "AgADAQADlagxG2EGUET6E8stSsgT5sDbbgYABAEAAwIAA20AA5VMAAIWBA"
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
    }
}
