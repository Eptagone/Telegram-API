// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Inline mode</summary>
    public static class Inlinemode
    {
        /// <summary>Use this method to send answers to an inline query. On success, True is returned. 
        /// No more than 50 results per query are allowed.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool AnswerInlineQuery(this BotClient T, AnswerInlineQueryArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineQueryResultConverter());
            options.Converters.Add(new JsonTools.InputMessageContentConverter());
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            JsonSerializer.Serialize(json, args, typeof(AnswerInlineQueryArgs), options);
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("answerInlineQuery", stream);
        }
        /// <summary>Use this method to send answers to an inline query. On success, True is returned. 
        /// No more than 50 results per query are allowed.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<bool> AnswerInlineQueryAsync(this BotClient T, AnswerInlineQueryArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new JsonTools.InlineQueryResultConverter());
            options.Converters.Add(new JsonTools.InputMessageContentConverter());
            options.Converters.Add(new JsonTools.InlineKeyboardMarkupConverter());
            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, args, typeof(AnswerInlineQueryArgs), options).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("answerInlineQuery", stream).ConfigureAwait(false);
        }
    }
}