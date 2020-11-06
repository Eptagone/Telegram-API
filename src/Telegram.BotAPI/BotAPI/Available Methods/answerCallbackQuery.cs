// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>true</returns>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AnswerCallbackQuery(
            this BotClient T,
            AnswerCallbackQueryArgs args)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            return T.RPC<bool>("answerCallbackQuery", args);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="callback_query_id">Unique identifier for the query to be answered.</param>
        /// <param name="text">Optional. Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</param>
        /// <param name="show_alert">Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</param>
        /// <param name="url">Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button. <br/>Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</param>
        /// <param name="cache_time">Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AnswerCallbackQuery(
            this BotClient T,
            string callback_query_id,
            [Optional] string text,
            [Optional] bool show_alert,
            [Optional] string url,
            [Optional] uint cache_time)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("callback_query_id", callback_query_id);
            if (text != default)
            {
                json.WriteString("text", text);
            }

            if (show_alert != default)
            {
                json.WriteBoolean("show_alert", show_alert);
            }

            if (url != default)
            {
                json.WriteString("url", url);
            }

            if (cache_time != default)
            {
                json.WriteNumber("cache_time", cache_time);
            }

            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("answerCallbackQuery", stream);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AnswerCallbackQueryAsync(
            this BotClient T,
            AnswerCallbackQueryArgs args,
            [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await T.RPCA<bool>("answerCallbackQuery", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="callback_query_id">Unique identifier for the query to be answered.</param>
        /// <param name="text">Optional. Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</param>
        /// <param name="show_alert">Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</param>
        /// <param name="url">Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button. <br/>Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</param>
        /// <param name="cache_time">Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AnswerCallbackQueryAsync(
            this BotClient T,
            string callback_query_id,
            [Optional] string text,
            [Optional] bool show_alert,
            [Optional] string url,
            [Optional] uint cache_time,
            [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("callback_query_id", callback_query_id);
            if (text != default)
            {
                json.WriteString("text", text);
            }

            if (show_alert != default)
            {
                json.WriteBoolean("show_alert", show_alert);
            }

            if (url != default)
            {
                json.WriteString("url", url);
            }

            if (cache_time != default)
            {
                json.WriteNumber("cache_time", cache_time);
            }

            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("answerCallbackQuery", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}