// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using File = Telegram.BotAPI.Available_Types.File;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="file_id">File identifier to get info about.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="File"/></returns>
        public static File GetFile(this BotClient bot, string file_id)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("file_id", file_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<File>("getFile", stream);
        }
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="file_id">File identifier to get info about.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="File"/></returns>
        public static async Task<File> GetFileAsync(this BotClient bot, string file_id, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("file_id", file_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<File>("getFile", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}