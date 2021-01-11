// Copyright (c) 2021 Quetzal Rivera.
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
        [Trait("SendMediaGroup", "Upload photos")]
        public void Test00()
        {
            var message = Settings.Bot.SendMediaGroup(
                new SendMediaGroupArgs
                {
                    Chat_id = Settings.PChatId,
                    Media = new InputMedia[]
                    {
                        new InputMediaPhoto{ Media = "attach://filephoto1", Caption = "<b>Stronger</b> shja", Parse_mode = "HTML"},
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
