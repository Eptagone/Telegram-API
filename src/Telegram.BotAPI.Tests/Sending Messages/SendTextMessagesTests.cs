// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed partial class SendingMessages
    {
        [Fact]
        [Trait("Send text", "SendMessageText")]
        public void SendMessageText()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Test Message Text"); //Send message text
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Send alter", "SendMessageText")]
        public void SendMessageTextAlter()
        {
            var message = Settings.Bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Settings.PChatId,
                    Text = "Test Message Alter Text"
                }); //Send message text alter
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("HTML", "Parse Mode")]
        public void SendMessageTextWithHTML()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "HTML Message\n<b>bold</b>,<strong>bold</strong>\n<i>italic</i>,<em>italic</em>\n<a href=\"https://core.telegram.org/Settings.Bots/api\">inline URL</a>\n<a href=\"tg://user?id=123456789\">inline mention of a user</a>\n<code>inline fixed-width code</code>\n<pre>pre - formatted fixed-width code block</pre>",
                Parse_mode = ParseMode.HTML
            }); //Send message with HTML
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Markdown", "Parse Mode")]
        public void SendMessageTextWithMarkdown()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Markdown Message\n*bold text*\n_italic text_\n[inline URL](https://core.telegram.org/Settings.Bots/api)\n[inline mention of a user](tg://user?id=123456789)\n`inline fixed-width code`\n```block_language\npre - formatted fixed-width code block\n```",
                Parse_mode = ParseMode.Markdown
            }); //Send message with Markdown
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Disable", "Web Page Preview")]
        public void SendMessageTextDisableWebPagePreview()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "<a href=\"https://core.telegram.org/Settings.Bots/api\">URL without disable web page preview</a>",
                Parse_mode = ParseMode.HTML
            }); //Send message without disable web page preview
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Enable", "Web Page Preview")]
        public void SendMessageTextEnableWebPagePreview()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "<a href=\"https://core.telegram.org/Settings.Bots/api\">URL with disable web page preview</a>",
                Parse_mode = ParseMode.HTML,
                Disable_web_page_preview = true
            }); //Send message with disable web page preview
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Silently", "Silently Message")]
        public void SendSilentlyMessage()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Test Silent Message",
                Disable_notification = true
            }); //Send silently message
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Send text", "SendMessageTextAsync")]
        public async void SendMessageTextAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(Settings.PChatId, "Test Message Text").ConfigureAwait(true); //Send message text
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Send alter", "SendMessageTextAsync")]
        public async void SendMessageTextAlterAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(
                new SendMessageArgs
                {
                    Chat_id = Settings.PChatId,
                    Text = "Test Message Alter Text"
                }).ConfigureAwait(true); //Send message text alter
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("HTML", "Parse Mode Async")]
        public async void SendMessageTextWithHTMLAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "HTML Message\n<b>bold</b>,<strong>bold</strong>\n<i>italic</i>,<em>italic</em>\n<a href=\"https://core.telegram.org/Settings.Bots/api\">inline URL</a>\n<a href=\"tg://user?id=123456789\">inline mention of a user</a>\n<code>inline fixed-width code</code>\n<pre>pre - formatted fixed-width code block</pre>",
                Parse_mode = ParseMode.HTML
            }).ConfigureAwait(true); //Send message with HTML
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Markdown", "Parse Mode Async")]
        public async void SendMessageTextWithMarkdownAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Markdown Message\n*bold text*\n_italic text_\n[inline URL](https://core.telegram.org/Settings.Bots/api)\n[inline mention of a user](tg://user?id=123456789)\n`inline fixed-width code`\n```block_language\npre - formatted fixed-width code block\n```",
                Parse_mode = ParseMode.Markdown
            }).ConfigureAwait(true); //Send message with Markdown
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Disable", "Web Page Preview Async")]
        public async void SendMessageTextDisableWebPagePreviewAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "<a href=\"https://core.telegram.org/Settings.Bots/api\">URL without disable web page preview</a>",
                Parse_mode = ParseMode.HTML
            }).ConfigureAwait(true); //Send message without disable web page preview
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Enable", "Web Page Preview Async")]
        public async void SendMessageTextEnableWebPagePreviewAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "<a href=\"https://core.telegram.org/Settings.Bots/api\">URL with disable web page preview</a>",
                Parse_mode = ParseMode.HTML,
                Disable_web_page_preview = true
            }).ConfigureAwait(true); //Send message with disable web page preview
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("Silently", "Silently Message Async")]
        public async void SendSilentlyMessageAsync()
        {
            var message = await Settings.Bot.SendMessageAsync(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Test Silent Message",
                Disable_notification = true
            }).ConfigureAwait(true); //Send silently message
            Assert.NotNull(message);
        }
    }
}
