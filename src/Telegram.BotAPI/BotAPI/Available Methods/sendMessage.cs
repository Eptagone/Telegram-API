// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, SendMessageArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Message>("sendMessage", args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, SendMessageArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<Message>("sendMessage", args).ConfigureAwait(true);
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
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, object chat_id, string text, string parse_mode = default, bool disable_web_page_preview = false, bool disable_notification = false, uint reply_to_message_id = default, ReplyMarkup reply_markup = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
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
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, object chat_id, string text, string parse_mode = default, bool disable_web_page_preview = false, bool disable_notification = false, uint reply_to_message_id = default, ReplyMarkup reply_markup = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
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
            return await T.RPCA<Message>("sendMessage", args).ConfigureAwait(true);
        }

        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, object chat_id, string text)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Message>("sendMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("text", text) });
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, object chat_id, string text)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<Message>("sendMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("text", text) }).ConfigureAwait(true);
        }

        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message.</param>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient T, object chat_id, string text, uint reply_to_message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Message>("sendMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("text", text), new JProperty("reply_to_message_id", reply_to_message_id) });
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient T, object chat_id, string text, uint reply_to_message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<Message>("sendMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("text", text), new JProperty("reply_to_message_id", reply_to_message_id) }).ConfigureAwait(true);
        }
    }
}