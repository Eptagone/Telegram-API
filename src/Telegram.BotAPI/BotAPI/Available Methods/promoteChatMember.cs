// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PromoteChatMember(this BotClient bot, PromoteChatMemberArgs args)
        {
            if (bot == default)
            {
                throw new System.ArgumentNullException(nameof(bot));
            }

            return bot.RPC<bool>(MethodNames.PromoteChatMember, args);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="isAnonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="canChangeInfo">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="canPostMessages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="canEditMessages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="canDeleteMessages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="canInviteUsers">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="canRestrictMembers">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="canPinMessages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="canPromoteMembers">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PromoteChatMember(this BotClient bot, string chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (chat_id == null)
            {
                throw new ArgumentNullException(nameof(chat_id));
            }

            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chat_id);
            json.WriteNumber(PropertyNames.UserId, user_id);
            json.WriteBoolean(PropertyNames.IsAnonymous, is_anonymous);
            json.WriteBoolean(PropertyNames.CanChangeInfo, can_change_info);
            json.WriteBoolean(PropertyNames.CanPostMessages, can_post_messages);
            json.WriteBoolean(PropertyNames.CanEditMessages, can_edit_messages);
            json.WriteBoolean(PropertyNames.CanDeleteMessages, can_delete_messages);
            json.WriteBoolean(PropertyNames.CanInviteUsers, can_invite_users);
            json.WriteBoolean(PropertyNames.CanRestrictMembers, can_restrict_members);
            json.WriteBoolean(PropertyNames.CanPinMessages, can_pin_messages);
            json.WriteBoolean(PropertyNames.CanPromoteMembers, can_promote_members);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.PromoteChatMember, stream);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="isAnonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="canChangeInfo">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="canPostMessages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="canEditMessages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="canDeleteMessages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="canInviteUsers">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="canRestrictMembers">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="canPinMessages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="canPromoteMembers">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PromoteChatMember(this BotClient bot, long chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chat_id);
            json.WriteNumber(PropertyNames.UserId, user_id);
            json.WriteBoolean(PropertyNames.IsAnonymous, is_anonymous);
            json.WriteBoolean(PropertyNames.CanChangeInfo, can_change_info);
            json.WriteBoolean(PropertyNames.CanPostMessages, can_post_messages);
            json.WriteBoolean(PropertyNames.CanEditMessages, can_edit_messages);
            json.WriteBoolean(PropertyNames.CanDeleteMessages, can_delete_messages);
            json.WriteBoolean(PropertyNames.CanInviteUsers, can_invite_users);
            json.WriteBoolean(PropertyNames.CanRestrictMembers, can_restrict_members);
            json.WriteBoolean(PropertyNames.CanPinMessages, can_pin_messages);
            json.WriteBoolean(PropertyNames.CanPromoteMembers, can_promote_members);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.PromoteChatMember, stream);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PromoteChatMemberAsync(this BotClient bot, PromoteChatMemberArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<bool>(MethodNames.PromoteChatMember, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="isAnonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="canChangeInfo">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="canPostMessages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="canEditMessages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="canDeleteMessages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="canInviteUsers">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="canRestrictMembers">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="canPinMessages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="canPromoteMembers">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PromoteChatMemberAsync(this BotClient bot, string chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (chat_id == null)
            {
                throw new ArgumentNullException(nameof(chat_id));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chat_id);
            json.WriteNumber(PropertyNames.UserId, user_id);
            json.WriteBoolean(PropertyNames.IsAnonymous, is_anonymous);
            json.WriteBoolean(PropertyNames.CanChangeInfo, can_change_info);
            json.WriteBoolean(PropertyNames.CanPostMessages, can_post_messages);
            json.WriteBoolean(PropertyNames.CanEditMessages, can_edit_messages);
            json.WriteBoolean(PropertyNames.CanDeleteMessages, can_delete_messages);
            json.WriteBoolean(PropertyNames.CanInviteUsers, can_invite_users);
            json.WriteBoolean(PropertyNames.CanRestrictMembers, can_restrict_members);
            json.WriteBoolean(PropertyNames.CanPinMessages, can_pin_messages);
            json.WriteBoolean(PropertyNames.CanPromoteMembers, can_promote_members);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.PromoteChatMember, stream, cancellationToken)
                .ConfigureAwait(false);
        }
        /// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="isAnonymous">Pass True, if the administrator's presence in the chat is hidden.</param>
        /// <param name="canChangeInfo">Optional. Pass True, if the administrator can change chat title, photo and other settings.</param>
        /// <param name="canPostMessages">Optional. Pass True, if the administrator can create channel posts, channels only.</param>
        /// <param name="canEditMessages">Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</param>
        /// <param name="canDeleteMessages">Optional. Pass True, if the administrator can delete messages of other users.</param>
        /// <param name="canInviteUsers">Optional. Pass True, if the administrator can invite new users to the chat.</param>
        /// <param name="canRestrictMembers">Optional. Pass True, if the administrator can restrict, ban or unban chat members</param>
        /// <param name="canPinMessages">Optional. Pass True, if the administrator can pin messages, supergroups only.</param>
        /// <param name="canPromoteMembers">Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PromoteChatMemberAsync(this BotClient bot, long chat_id, int user_id, [Optional] bool is_anonymous, [Optional] bool can_change_info, [Optional] bool can_post_messages, [Optional] bool can_edit_messages, [Optional] bool can_delete_messages, [Optional] bool can_invite_users, [Optional] bool can_restrict_members, [Optional] bool can_pin_messages, [Optional] bool can_promote_members, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chat_id);
            json.WriteNumber(PropertyNames.UserId, user_id);
            json.WriteBoolean(PropertyNames.IsAnonymous, is_anonymous);
            json.WriteBoolean(PropertyNames.CanChangeInfo, can_change_info);
            json.WriteBoolean(PropertyNames.CanPostMessages, can_post_messages);
            json.WriteBoolean(PropertyNames.CanEditMessages, can_edit_messages);
            json.WriteBoolean(PropertyNames.CanDeleteMessages, can_delete_messages);
            json.WriteBoolean(PropertyNames.CanInviteUsers, can_invite_users);
            json.WriteBoolean(PropertyNames.CanRestrictMembers, can_restrict_members);
            json.WriteBoolean(PropertyNames.CanPinMessages, can_pin_messages);
            json.WriteBoolean(PropertyNames.CanPromoteMembers, can_promote_members);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.PromoteChatMember, stream, cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
