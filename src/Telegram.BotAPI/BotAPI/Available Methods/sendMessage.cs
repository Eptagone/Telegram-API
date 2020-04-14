﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, SendMessageArgs args)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (args == default)
                throw new ArgumentNullException(nameof(args));
            return T.RPC<Message>("sendMessage", args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, SendMessageArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (args == default)
                throw new ArgumentNullException(nameof(args));
            return await T.RPCA<Message>("sendMessage", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, object chat_id, string text, [Optional] string parse_mode, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var args = new SendMessageArgs()
            {
                Chat_id = chat_id,
                Text = text
            };
            if (parse_mode != default)
                args.Parse_mode = parse_mode;
            if (disable_web_page_preview)
                args.Disable_web_page_preview = true;
            if (disable_notification)
                args.Disable_notification = true;
            if (reply_to_message_id != default)
                args.Reply_to_message_id = reply_to_message_id;
            if (reply_markup != default)
                args.Reply_markup = reply_markup;
            return T.RPC<Message>("sendMessage", args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="reply_markup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, object chat_id, string text, [Optional] string parse_mode, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] ReplyMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var args = new SendMessageArgs()
            {
                Chat_id = chat_id,
                Text = text
            };
            if (parse_mode != default)
                args.Parse_mode = parse_mode;
            if (disable_web_page_preview)
                args.Disable_web_page_preview = true;
            if (disable_notification)
                args.Disable_notification = true;
            if (reply_to_message_id != default)
                args.Reply_to_message_id = reply_to_message_id;
            if (reply_markup != default)
                args.Reply_markup = reply_markup;
            return await T.RPCA<Message>("sendMessage", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, long chat_id, string text, [Optional] string parse_mode, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("text", text);
            if (parse_mode != default)
                json.WriteString("parse_mode", parse_mode);
            if (disable_web_page_preview != default)
                json.WriteBoolean("disable_web_page_preview", disable_web_page_preview);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            if (reply_to_message_id != default)
                json.WriteNumber("reply_to_message_id", reply_to_message_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Message>("sendMessage", stream);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parse_mode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disable_web_page_preview">Disables link previews for links in this message</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, long chat_id, string text, [Optional] string parse_mode, [Optional] bool disable_web_page_preview, [Optional] bool disable_notification, [Optional] uint reply_to_message_id, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("text", text);
            if (parse_mode != default)
                json.WriteString("parse_mode", parse_mode);
            if (disable_web_page_preview != default)
                json.WriteBoolean("disable_web_page_preview", disable_web_page_preview);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            if (reply_to_message_id != default)
                json.WriteNumber("reply_to_message_id", reply_to_message_id);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Message>("sendMessage", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}