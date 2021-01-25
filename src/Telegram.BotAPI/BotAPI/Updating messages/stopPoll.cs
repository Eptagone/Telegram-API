// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    /// <summary>Updating messages</summary>
    public static partial class UpdatingMessagesExtensions
    {
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, long chat_id, uint message_id)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Poll>("stopPoll", stream);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, string chat_id, uint message_id)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Poll>("stopPoll", stream);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, long chat_id, uint message_id, InlineKeyboardMarkup reply_markup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (reply_markup == default)
            {
                throw new ArgumentNullException(nameof(reply_markup));
            }

            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return bot.RPC<Poll>("stopPoll", args);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, string chat_id, uint message_id, InlineKeyboardMarkup reply_markup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (reply_markup == default)
            {
                throw new ArgumentNullException(nameof(reply_markup));
            }

            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return bot.RPC<Poll>("stopPoll", args);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, long chat_id, uint message_id, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Poll>("stopPoll", stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, string chat_id, uint message_id, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Poll>("stopPoll", stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, long chat_id, uint message_id, [Optional] InlineKeyboardMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (reply_markup == default)
            {
                throw new ArgumentNullException(nameof(reply_markup));
            }

            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return await bot.RPCA<Poll>("stopPoll", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the original message with the poll</param>
        /// <param name="reply_markup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, string chat_id, uint message_id, InlineKeyboardMarkup reply_markup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (reply_markup == default)
            {
                throw new ArgumentNullException(nameof(reply_markup));
            }

            var args = new StopPollArgs
            {
                Chat_id = chat_id,
                Message_id = message_id,
                Reply_markup = reply_markup
            };
            return await bot.RPCA<Poll>("stopPoll", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, StopPollArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Poll>("stopPoll", args);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, StopPollArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Poll>("stopPoll", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
