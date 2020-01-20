﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to set a new group sticker set for a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Use the field can_set_sticker_set optionally returned in getChat requests to check if the bot can use this method. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="sticker_set_name">Name of the sticker set to be set as the group sticker set.</param>
        public static bool SetChatStickerSet(this BotClient T, long chat_id, string sticker_set_name)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("sticker_set_name", sticker_set_name);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setChatStickerSet", stream);
        }
        /// <summary>Use this method to set a new group sticker set for a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Use the field can_set_sticker_set optionally returned in getChat requests to check if the bot can use this method. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="sticker_set_name">Name of the sticker set to be set as the group sticker set.</param>
        public static bool SetChatStickerSet(this BotClient T, string chat_id, string sticker_set_name)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteString("sticker_set_name", sticker_set_name);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setChatStickerSet", stream);
        }
        /// <summary>Use this method to set a new group sticker set for a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Use the field can_set_sticker_set optionally returned in getChat requests to check if the bot can use this method. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="sticker_set_name">Name of the sticker set to be set as the group sticker set.</param>
        public static async Task<bool> SetChatStickerSetAsync(this BotClient T, long chat_id, string sticker_set_name)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("sticker_set_name", sticker_set_name);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setChatStickerSet", stream).ConfigureAwait(false);
        }
        /// <summary>Use this method to set a new group sticker set for a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Use the field can_set_sticker_set optionally returned in getChat requests to check if the bot can use this method. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="sticker_set_name">Name of the sticker set to be set as the group sticker set.</param>
        public static async Task<bool> SetChatStickerSetAsync(this BotClient T, string chat_id, string sticker_set_name)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteString("sticker_set_name", sticker_set_name);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setChatStickerSet", stream).ConfigureAwait(false);
        }
    }
}