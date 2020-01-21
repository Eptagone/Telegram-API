// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    /// <summary>Updating messages</summary>
    public static partial class UpdatingMessages
    {
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        public static Poll StopPoll(this BotClient T, long chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Poll>("stopPoll", stream);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        public static Poll StopPoll(this BotClient T, string chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Poll>("stopPoll", stream);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        public static Poll StopPoll(this BotClient T, long chat_id, uint message_id, InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (reply_markup == default)
                throw new System.ArgumentNullException(nameof(reply_markup));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return T.RPC<Poll>("stopPoll", args, options);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        public static Poll StopPoll(this BotClient T, string chat_id, uint message_id, InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (reply_markup == default)
                throw new System.ArgumentNullException(nameof(reply_markup));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return T.RPC<Poll>("stopPoll", args, options);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        public static async Task<Poll> StopPollAsync(this BotClient T, long chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Poll>("stopPoll", stream).ConfigureAwait(false);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        public static async Task<Poll> StopPollAsync(this BotClient T, string chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Poll>("stopPoll", stream).ConfigureAwait(false);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        public static async Task<Poll> StopPollAsync(this BotClient T, long chat_id, uint message_id, InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (reply_markup == default)
                throw new System.ArgumentNullException(nameof(reply_markup));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return await T.RPCA<Poll>("stopPoll", args, options).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        public static async Task<Poll> StopPollAsync(this BotClient T, string chat_id, uint message_id, InlineKeyboardMarkup reply_markup)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (reply_markup == default)
                throw new System.ArgumentNullException(nameof(reply_markup));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return await T.RPCA<Poll>("stopPoll", args, options).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static Poll StopPoll(this BotClient T, StopPollArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            return T.RPC<Poll>("stopPoll", args, options);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<Poll> StopPollAsync(this BotClient T, StopPollArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            return await T.RPCA<Poll>("stopPoll", args, options).ConfigureAwait(false);
        }
    }
}
