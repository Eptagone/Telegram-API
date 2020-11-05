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
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be removed from the chat. If you don't want this, use the parameter only_if_banned. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @username).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="only_if_banned">Do nothing if the user is not banned</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool UnbanChatMember(this BotClient T, long chat_id, int user_id, [Optional] bool only_if_banned)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (only_if_banned)
                json.WriteBoolean("only_if_banned", only_if_banned);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("unbanChatMember", stream);
        }
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be removed from the chat. If you don't want this, use the parameter only_if_banned. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @username).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="only_if_banned">Do nothing if the user is not banned</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool UnbanChatMember(this BotClient T, string chat_id, int user_id, [Optional] bool only_if_banned)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (only_if_banned)
                json.WriteBoolean("only_if_banned", only_if_banned);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("unbanChatMember", stream);
        }
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be removed from the chat. If you don't want this, use the parameter only_if_banned. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @username).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="only_if_banned">Do nothing if the user is not banned</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> UnbanChatMemberAsync(this BotClient T, long chat_id, int user_id, [Optional] bool only_if_banned, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (only_if_banned)
                json.WriteBoolean("only_if_banned", only_if_banned);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("unbanChatMember", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be removed from the chat. If you don't want this, use the parameter only_if_banned. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @username).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="only_if_banned">Do nothing if the user is not banned</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> UnbanChatMemberAsync(this BotClient T, string chat_id, int user_id, [Optional] bool only_if_banned, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            if (only_if_banned)
                json.WriteBoolean("only_if_banned", only_if_banned);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("unbanChatMember", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}