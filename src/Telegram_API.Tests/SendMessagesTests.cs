// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI;
using TelegramAPI.Available_Methods;
using Xunit;

namespace Telegram_API.Tests
{
    public class SendMessages
    {
        [Fact]
        public void SendMessageText()
        {
            var message = Tools.bot.SendMessage(Tools.chat_id, "Test Message Text"); //Send message text
            Assert.NotNull(message);
        }
        [Fact]
        public void SendMessageTextAlter()
        {
            var message = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "Test Message Alter Text"
                }); //Send message text alter
            Assert.NotNull(message);
        }
        [Fact]
        public void SendMessageTextWithHTML()
        {
            var message = Tools.bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Tools.chat_id,
                Text = "HTML Message\n<b>bold</b>,<strong>bold</strong>\n<i>italic</i>,<em>italic</em>\n<a href=\"https://core.telegram.org/bots/api\">inline URL</a>\n<a href=\"tg://user?id=123456789\">inline mention of a user</a>\n<code>inline fixed-width code</code>\n<pre>pre - formatted fixed-width code block</pre>",
                Parse_mode = ParseMode.HTML
            }); //Send message with HTML
            Assert.NotNull(message);
        }
        [Fact]
        public void SendMessageTextWithMarkdown()
        {
            var message = Tools.bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Tools.chat_id,
                Text = "Markdown Message\n*bold text*\n_italic text_\n[inline URL](https://core.telegram.org/bots/api)\n[inline mention of a user](tg://user?id=123456789)\n`inline fixed-width code`\n```block_language\npre - formatted fixed-width code block\n```",
                Parse_mode = ParseMode.Markdown
            }); //Send message with Markdown
            Assert.NotNull(message);
        }
        [Fact]
        public void ReplyToMessage()
        {
            var message = Tools.bot.SendMessage(Tools.chat_id, "Message to be reply"); //Message to be reply
            var reply = Tools.bot.SendMessage(Tools.chat_id, "Reply message", message.Message_id); //Reply
            Assert.NotNull(reply.Reply_to_message);
        }
        [Fact]
        public void ReplyToMessageAlter()
        {
            var message = Tools.bot.SendMessage(Tools.chat_id, "Message to be reply"); //Message to be reply
            var reply = Tools.bot.SendMessage(
                new SendMessageArgs
                {
                    Chat_id = Tools.chat_id,
                    Text = "Reply message Alter",
                    Reply_to_message_id = message.Message_id
                }); //Reply Alter
            Assert.NotNull(reply.Reply_to_message);
        }
        [Fact]
        public void SendMessageWithoutDisableWebPagePreview()
        {
            var message = Tools.bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Tools.chat_id,
                Text = "<a href=\"https://core.telegram.org/bots/api\">URL without disable web page preview</a>",
                Parse_mode = ParseMode.HTML
            }); //Send message without disable web page preview
            Assert.NotNull(message);
        }
        [Fact]
        public void SendMessageWithDisableWebPagePreview()
        {
            var message = Tools.bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Tools.chat_id,
                Text = "<a href=\"https://core.telegram.org/bots/api\">URL with disable web page preview</a>",
                Parse_mode = ParseMode.HTML,
                Disable_web_page_preview = true
            }); //Send message with disable web page preview
            Assert.NotNull(message);
        }
        [Fact]
        public void SendSilentlyMessage()
        {
            var message = Tools.bot.SendMessage(new SendMessageArgs
            {
                Chat_id = Tools.chat_id,
                Text = "Test Silent Message",
                Disable_notification = true
            }); //Send silently message
            Assert.NotNull(message);
        }
    }
}
