// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>Stickers</summary>
    public static partial class StickersMethods
    {
        /// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        /// <param name="position">New sticker position in the set, zero-based.</param>
        public static bool SetStickerPositionInSet(this BotClient T, string sticker, int position)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("sticker", sticker);
            json.WriteNumber("position", position);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setStickerPositionInSet", stream);
        }
        /// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        /// <param name="position">New sticker position in the set, zero-based.</param>
        public static async Task<bool> SetStickerPositionInSetAsync(this BotClient T, string sticker, int position)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("sticker", sticker);
            json.WriteNumber("position", position);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setStickerPositionInSet", stream).ConfigureAwait(false);
        }
    }
}