// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Available_Methods;
using Telegram.BotAPI.Available_Types;
using Xunit;

namespace Telegram.BotAPI.Tests
{
    public sealed class SendMessage
    {
        [Fact]
        [Trait("SendMessage", "Text only")]
        public void Test00()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Test Message Text");
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessageAlter", "Text only")]
        public void Test01()
        {
            var message = Settings.Bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Settings.PChatId,
                    Text = "Test Message Alter Text"
                });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessage", "ParseMode: HTML")]
        public void Test02()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "HTML Message\n<b>bold</b>,<strong>bold</strong>\n<i>italic</i>,<em>italic</em>\n<a href=\"https://core.telegram.org/Settings.Bots/api\">inline URL</a>\n<a href=\"tg://user?id=123456789\">inline mention of a user</a>\n<code>inline fixed-width code</code>\n<pre>pre - formatted fixed-width code block</pre>", ParseMode.HTML);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessageAlter", "ParseMode: HTML")]
        public void Test03()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "HTML Message\n<b>bold</b>,<strong>bold</strong>\n<i>italic</i>,<em>italic</em>\n<a href=\"https://core.telegram.org/Settings.Bots/api\">inline URL</a>\n<a href=\"tg://user?id=123456789\">inline mention of a user</a>\n<code>inline fixed-width code</code>\n<pre>pre - formatted fixed-width code block</pre>",
                Parse_mode = ParseMode.HTML
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessage", "ParseMode: Markdown")]
        public void Test04()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Markdown Message\n*bold text*\n_italic text_\n[inline URL](https://core.telegram.org/Settings.Bots/api)\n[inline mention of a user](tg://user?id=123456789)\n`inline fixed-width code`\n```block_language\npre - formatted fixed-width code block\n```", ParseMode.Markdown);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessageAlter", "ParseMode: Markdown")]
        public void Test05()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Markdown Message\n*bold text*\n_italic text_\n[inline URL](https://core.telegram.org/Settings.Bots/api)\n[inline mention of a user](tg://user?id=123456789)\n`inline fixed-width code`\n```block_language\npre - formatted fixed-width code block\n```",
                Parse_mode = ParseMode.Markdown
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessage", "Disable Web Page Preview")]
        public void Test06()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "<a href=\"https://core.telegram.org/Settings.Bots/api\">URL without disable web page preview</a>", ParseMode.HTML, disable_web_page_preview: true);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessageAlter", "Disable Web Page Preview")]
        public void Test07()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "<a href=\"https://core.telegram.org/Settings.Bots/api\">URL without disable web page preview</a>",
                Parse_mode = ParseMode.HTML,
                Disable_web_page_preview = true
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessage", "Disable Notification")]
        public void Test08()
        {
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Test Silent Message", disable_notification: true);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessageAlter", "Disable Notification")]
        public void Test09()
        {
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Test Silent Message",
                Disable_notification = true
            });
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessage", "Reply to message")]
        public void Test10()
        {
            var messagereply = Settings.Bot.SendMessage(Settings.PChatId, "Reply me");
            var message = Settings.Bot.SendMessage(Settings.PChatId, "Test Silent Message", reply_to_message_id: messagereply.Message_id);
            Assert.NotNull(message);
        }
        [Fact]
        [Trait("SendMessageAlter", "Reply to message")]
        public void Test11()
        {
            var messagereply = Settings.Bot.SendMessage(Settings.PChatId, "Reply me");
            var message = Settings.Bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Settings.PChatId,
                Text = "Test Silent Message",
                Reply_to_message_id = messagereply.Message_id
            });
            Assert.NotNull(message);
        }
    }
}
