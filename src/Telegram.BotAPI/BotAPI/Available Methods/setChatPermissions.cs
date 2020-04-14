// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SetChatPermissions(this BotClient T, long chat_id, Available_Types.ChatPermissions permissions)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (permissions == default)
                throw new ArgumentNullException(nameof(permissions));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteStartObject("permissions");
            if (permissions.Can_send_messages)
                json.WriteBoolean("can_send_messages", true);
            if (permissions.Can_send_media_messages)
                json.WriteBoolean("can_send_media_messages", true);
            if (permissions.Can_send_polls)
                json.WriteBoolean("can_send_polls", true);
            if (permissions.Can_send_other_messages)
                json.WriteBoolean("can_send_other_messages", true);
            if (permissions.Can_add_web_page_previews)
                json.WriteBoolean("can_add_web_page_previews", true);
            if (permissions.Can_change_info)
                json.WriteBoolean("can_change_info", true);
            if (permissions.Can_invite_users)
                json.WriteBoolean("can_invite_users", true);
            if (permissions.Can_pin_messages)
                json.WriteBoolean("can_pin_messages", true);
            json.WriteEndObject();
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setChatPermissions", stream);
        }
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SetChatPermissions(this BotClient T, string chat_id, Available_Types.ChatPermissions permissions)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (permissions == default)
                throw new ArgumentNullException(nameof(permissions));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteStartObject("permissions");
            if (permissions.Can_send_messages)
                json.WriteBoolean("can_send_messages", true);
            if (permissions.Can_send_media_messages)
                json.WriteBoolean("can_send_media_messages", true);
            if (permissions.Can_send_polls)
                json.WriteBoolean("can_send_polls", true);
            if (permissions.Can_send_other_messages)
                json.WriteBoolean("can_send_other_messages", true);
            if (permissions.Can_add_web_page_previews)
                json.WriteBoolean("can_add_web_page_previews", true);
            if (permissions.Can_change_info)
                json.WriteBoolean("can_change_info", true);
            if (permissions.Can_invite_users)
                json.WriteBoolean("can_invite_users", true);
            if (permissions.Can_pin_messages)
                json.WriteBoolean("can_pin_messages", true);
            json.WriteEndObject();
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setChatPermissions", stream);
        }
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SetChatPermissionsAsync(this BotClient T, long chat_id, Available_Types.ChatPermissions permissions, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (permissions == default)
                throw new ArgumentNullException(nameof(permissions));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteStartObject("permissions");
            if (permissions.Can_send_messages)
                json.WriteBoolean("can_send_messages", true);
            if (permissions.Can_send_media_messages)
                json.WriteBoolean("can_send_media_messages", true);
            if (permissions.Can_send_polls)
                json.WriteBoolean("can_send_polls", true);
            if (permissions.Can_send_other_messages)
                json.WriteBoolean("can_send_other_messages", true);
            if (permissions.Can_add_web_page_previews)
                json.WriteBoolean("can_add_web_page_previews", true);
            if (permissions.Can_change_info)
                json.WriteBoolean("can_change_info", true);
            if (permissions.Can_invite_users)
                json.WriteBoolean("can_invite_users", true);
            if (permissions.Can_pin_messages)
                json.WriteBoolean("can_pin_messages", true);
            json.WriteEndObject();
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setChatPermissions", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SetChatPermissionsAsync(this BotClient T, string chat_id, Available_Types.ChatPermissions permissions, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (permissions == default)
                throw new ArgumentNullException(nameof(permissions));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteStartObject("permissions");
            if (permissions.Can_send_messages)
                json.WriteBoolean("can_send_messages", true);
            if (permissions.Can_send_media_messages)
                json.WriteBoolean("can_send_media_messages", true);
            if (permissions.Can_send_polls)
                json.WriteBoolean("can_send_polls", true);
            if (permissions.Can_send_other_messages)
                json.WriteBoolean("can_send_other_messages", true);
            if (permissions.Can_add_web_page_previews)
                json.WriteBoolean("can_add_web_page_previews", true);
            if (permissions.Can_change_info)
                json.WriteBoolean("can_change_info", true);
            if (permissions.Can_invite_users)
                json.WriteBoolean("can_invite_users", true);
            if (permissions.Can_pin_messages)
                json.WriteBoolean("can_pin_messages", true);
            json.WriteEndObject();
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setChatPermissions", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
