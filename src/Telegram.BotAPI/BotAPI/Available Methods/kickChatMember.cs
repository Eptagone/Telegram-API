﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// /// <param name="until_date">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        public static bool KickChatMember(this BotClient T, long chat_id, int user_id, [Optional] uint until_date)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (until_date != default)
                json.WriteNumber("until_date", until_date);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("kickChatMember", stream);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// /// <param name="until_date">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        public static bool KickChatMember(this BotClient T, string chat_id, int user_id, [Optional] uint until_date)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (until_date != default)
                json.WriteNumber("until_date", until_date);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("kickChatMember", stream);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// /// <param name="until_date">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        public static async Task<bool> KickChatMemberAsync(this BotClient T, long chat_id, int user_id, [Optional] int until_date)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (until_date != default)
                json.WriteNumber("until_date", until_date);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("kickChatMember", stream).ConfigureAwait(false);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// /// <param name="until_date">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        public static async Task<bool> KickChatMemberAsync(this BotClient T, string chat_id, int user_id, [Optional] int until_date)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (until_date != default)
                json.WriteNumber("until_date", until_date);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("kickChatMember", stream).ConfigureAwait(false);
        }
    }
}