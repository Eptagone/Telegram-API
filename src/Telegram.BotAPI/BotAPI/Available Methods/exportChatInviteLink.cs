﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to generate a new invite link for a chat; any previously generated link is revoked. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the new invite link as String on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        public static string ExportChatInviteLink(this BotClient T, long chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<string>("exportChatInviteLink", stream);
        }
        /// <summary>Use this method to generate a new invite link for a chat; any previously generated link is revoked. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the new invite link as String on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        public static string ExportChatInviteLink(this BotClient T, string chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<string>("exportChatInviteLink", stream);
        }
        /// <summary>Use this method to generate a new invite link for a chat; any previously generated link is revoked. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the new invite link as String on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        public static async Task<string> ExportChatInviteLinkAsync(this BotClient T, long chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<string>("exportChatInviteLink", stream).ConfigureAwait(false);
        }
        /// <summary>Use this method to generate a new invite link for a chat; any previously generated link is revoked. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns the new invite link as String on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        public static async Task<string> ExportChatInviteLinkAsync(this BotClient T, string chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<string>("exportChatInviteLink", stream).ConfigureAwait(false);
        }
    }
}