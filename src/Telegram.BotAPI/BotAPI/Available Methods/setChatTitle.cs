﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static bool SetChatTitle(this BotClient T, long chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("title", title);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setChatTitle", stream);
        }
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static bool SetChatTitle(this BotClient T, string chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteString("title", title);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setChatTitle", stream);
        }
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static async Task<bool> SetChatTitleAsync(this BotClient T, long chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("title", title);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setChatTitle", stream).ConfigureAwait(false);
        }
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static async Task<bool> SetChatTitleAsync(this BotClient T, string chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteString("title", title);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setChatTitle", stream).ConfigureAwait(false);
        }
    }
}