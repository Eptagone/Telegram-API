// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient bot, SendMessageArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Message>("sendMessage", args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient bot, SendMessageArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Message>("sendMessage", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="entities">List of special entities that appear in message text, which can be specified instead of parse_mode.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient bot, object chat_id, string text, [Optional] string parse_mode, [Optional] IEnumerable<MessageEntity> entities, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] ReplyMarkup reply_markup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new SendMessageArgs()
            {
                ChatId = chat_id,
                Text = text
            };
            if (parse_mode != default)
            {
                args.ParseMode = parse_mode;
            }

            if (entities != default)
            {
                args.Entities = entities;
            }

            args.DisableWebPagePreview = disable_web_page_preview;
            args.DisableNotification = disable_notification;
            if (reply_to_message_id != default)
            {
                args.ReplyToMessageId = reply_to_message_id;
            }

            args.AllowSendingWithoutReply = allow_sending_without_reply;
            if (reply_markup != default)
            {
                args.ReplyMarkup = reply_markup;
            }

            return bot.RPC<Message>("sendMessage", args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="entities">List of special entities that appear in message text, which can be specified instead of parse_mode.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient bot, object chat_id, string text, [Optional] string parse_mode, [Optional] IEnumerable<MessageEntity> entities, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new SendMessageArgs()
            {
                ChatId = chat_id,
                Text = text
            };
            if (parse_mode != default)
            {
                args.ParseMode = parse_mode;
            }

            if (entities != default)
            {
                args.Entities = entities;
            }

            args.DisableWebPagePreview = disable_web_page_preview;
            args.DisableNotification = disable_notification;
            if (reply_to_message_id != default)
            {
                args.ReplyToMessageId = reply_to_message_id;
            }

            args.AllowSendingWithoutReply = allow_sending_without_reply;
            if (reply_markup != default)
            {
                args.ReplyMarkup = reply_markup;
            }

            return await bot.RPCA<Message>("sendMessage", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient bot, long chat_id, string text, [Optional] string parse_mode, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("text", text);
            if (parse_mode != default)
            {
                json.WriteString("parse_mode", parse_mode);
            }

            if (disable_web_page_preview)
            {
                json.WriteBoolean("disable_web_page_preview", disable_web_page_preview);
            }

            if (disable_notification)
            {
                json.WriteBoolean("disable_notification", disable_notification);
            }

            if (reply_to_message_id != default)
            {
                json.WriteNumber("reply_to_message_id", reply_to_message_id);
            }

            if (allow_sending_without_reply)
            {
                json.WriteBoolean("allow_sending_without_reply", allow_sending_without_reply);
            }

            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Message>("sendMessage", stream);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="allow_sending_without_reply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient bot, long chat_id, string text, [Optional] string parse_mode, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] bool allow_sending_without_reply, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("text", text);
            if (parse_mode != default)
            {
                json.WriteString("parse_mode", parse_mode);
            }

            if (disable_web_page_preview)
            {
                json.WriteBoolean("disable_web_page_preview", disable_web_page_preview);
            }

            if (disable_notification)
            {
                json.WriteBoolean("disable_notification", disable_notification);
            }

            if (allow_sending_without_reply)
            {
                json.WriteBoolean("allow_sending_without_reply", allow_sending_without_reply);
            }

            if (reply_to_message_id != default)
            {
                json.WriteNumber("reply_to_message_id", reply_to_message_id);
            }

            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Message>("sendMessage", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}