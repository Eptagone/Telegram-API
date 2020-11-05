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
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PromoteChatMember(this BotClient T, PromoteChatMemberArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("promoteChatMember", args);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="is_anonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="can_change_info">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="can_post_messages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="can_edit_messages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="can_delete_messages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="can_invite_users">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="can_restrict_members">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="can_pin_messages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="can_promote_members">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PromoteChatMember(this BotClient T, string chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (chat_id == null)
                throw new ArgumentNullException(nameof(chat_id));
            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteBoolean("is_anonymous", is_anonymous);
            json.WriteBoolean("can_change_info", can_change_info);
            json.WriteBoolean("can_post_messages", can_post_messages);
            json.WriteBoolean("can_edit_messages", can_edit_messages);
            json.WriteBoolean("can_delete_messages", can_delete_messages);
            json.WriteBoolean("can_invite_users", can_invite_users);
            json.WriteBoolean("can_restrict_members", can_restrict_members);
            json.WriteBoolean("can_pin_messages", can_pin_messages);
            json.WriteBoolean("can_promote_members", can_promote_members);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("promoteChatMember", stream);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="is_anonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="can_change_info">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="can_post_messages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="can_edit_messages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="can_delete_messages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="can_invite_users">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="can_restrict_members">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="can_pin_messages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="can_promote_members">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PromoteChatMember(this BotClient T, long chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteBoolean("is_anonymous", is_anonymous);
            json.WriteBoolean("can_change_info", can_change_info);
            json.WriteBoolean("can_post_messages", can_post_messages);
            json.WriteBoolean("can_edit_messages", can_edit_messages);
            json.WriteBoolean("can_delete_messages", can_delete_messages);
            json.WriteBoolean("can_invite_users", can_invite_users);
            json.WriteBoolean("can_restrict_members", can_restrict_members);
            json.WriteBoolean("can_pin_messages", can_pin_messages);
            json.WriteBoolean("can_promote_members", can_promote_members);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("promoteChatMember", stream);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PromoteChatMemberAsync(this BotClient T, PromoteChatMemberArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (args == default)
                throw new ArgumentNullException(nameof(args));
            return await T.RPCA<bool>("promoteChatMember", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="is_anonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="can_change_info">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="can_post_messages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="can_edit_messages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="can_delete_messages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="can_invite_users">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="can_restrict_members">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="can_pin_messages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="can_promote_members">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PromoteChatMemberAsync(this BotClient T, string chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            if (chat_id == null)
                throw new ArgumentNullException(nameof(chat_id));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteBoolean("is_anonymous", is_anonymous);
            json.WriteBoolean("can_change_info", can_change_info);
            json.WriteBoolean("can_post_messages", can_post_messages);
            json.WriteBoolean("can_edit_messages", can_edit_messages);
            json.WriteBoolean("can_delete_messages", can_delete_messages);
            json.WriteBoolean("can_invite_users", can_invite_users);
            json.WriteBoolean("can_restrict_members", can_restrict_members);
            json.WriteBoolean("can_pin_messages", can_pin_messages);
            json.WriteBoolean("can_promote_members", can_promote_members);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("promoteChatMember", stream, cancellationToken)
                .ConfigureAwait(false);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="is_anonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="can_change_info">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="can_post_messages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="can_edit_messages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="can_delete_messages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="can_invite_users">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="can_restrict_members">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="can_pin_messages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="can_promote_members">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PromoteChatMemberAsync(this BotClient T, long chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteBoolean("is_anonymous", is_anonymous);
            json.WriteBoolean("can_change_info", can_change_info);
            json.WriteBoolean("can_post_messages", can_post_messages);
            json.WriteBoolean("can_edit_messages", can_edit_messages);
            json.WriteBoolean("can_delete_messages", can_delete_messages);
            json.WriteBoolean("can_invite_users", can_invite_users);
            json.WriteBoolean("can_restrict_members", can_restrict_members);
            json.WriteBoolean("can_pin_messages", can_pin_messages);
            json.WriteBoolean("can_promote_members", can_promote_members);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("promoteChatMember", stream, cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
