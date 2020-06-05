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
        [Trait("Upload doc", "Send Document")]
        public void SendDocumentUpload()
        {
            var message = Settings.Bot.SendDocument(
                new SendDocumentArgs
                {
                    Chat_id = Settings.PChatId,
                    Document = new InputFile(Resources.sampletextfile, "sampletextfile.txt")
                });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload doc alter", "Send Document")]
        public void SendDocumentUploadAlter()
        {
            var message = Settings.Bot.SendDocument(
                new SendDocumentArgs
                {
                    Chat_id = Settings.PChatId,
                    Document = "attach://doc_file",
                    AttachFiles = new AttachFile[]
                    {
                        new AttachFile("doc_file", new InputFile(Resources.sampletextfile, "sampletextfile.txt"))
                    }
                });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload doc with thumb", "Send Document")]
        public void SendDocumentUploadWithThumb()
        {
            var message = Settings.Bot.SendDocument(
                new SendDocumentArgs
                {
                    Chat_id = Settings.PChatId,
                    Document = new InputFile(Resources.sampletextfile, "sampletextfile.txt"),
                    Thumb = new InputFile(Resources.Thumb_256x256, "Thumb 256x256.jpg")
                });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Upload doc with thumb alter", "Send Document")]
        public void SendDocumentUploadThumbWithThumbAlter()
        {
            var message = Settings.Bot.SendDocument(
                new SendDocumentArgs
                {
                    Chat_id = Settings.PChatId,
                    Document = "attach://doc_file",
                    Thumb = "attach://thumb_file",
                    AttachFiles = new AttachFile[]
                    {
                        new AttachFile("doc_file", new InputFile(Resources.sampletextfile, "sampletextfile.txt")),
                        new AttachFile("thumb_file", new InputFile(Resources.Thumb_256x256, "Thumb 256x256.jpg"))
                    }
                });
            Assert.NotNull(message);
        }
    }
}
