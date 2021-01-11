// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to get a sticker set. On success, a StickerSet object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Name of the sticker set.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="StickerSet"/> object.</returns>
        public static StickerSet GetStickerSet(this BotClient T, string name)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("name", name);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<StickerSet>("getStickerSet", stream);
        }
        /// <summary>Use this method to get a sticker set. On success, a StickerSet object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Name of the sticker set.</param>
        /// <returns><see cref="StickerSet"/> object.</returns>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<StickerSet> GetStickerSetAsync(this BotClient T, string name, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("name", name);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<StickerSet>("getStickerSet", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}