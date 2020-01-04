﻿// Copyright (c) 2020 Quetzal Rivera.
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
        [Trait("Upload photos", "SendMediaGroup")]
        public void SendMediaGroupTest()
        {
            var message = bot.SendMediaGroup(
                new SendMediaGroupArgs
                {
                    Chat_id = chat_id,
                    Media = new InputMedia[]
                    {
                        new InputMediaPhoto{ Media = "attach://filephoto1"},
                        new InputMediaPhoto{ Media = "attach://filephoto2"},
                        new InputMediaPhoto{ Media = "attach://filephoto3"}
                    },
                    AttachFiles = new AttachFile[]
                    {
                        new AttachFile("filephoto1", new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")),
                        new AttachFile("filephoto2", new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg")),
                        new AttachFile("filephoto3", new InputFile(Resources.Image_sample_JPG, "Image sample JPG.jpg"))
                    }
                });
            Assert.NotNull(message);
        }
    }
}
