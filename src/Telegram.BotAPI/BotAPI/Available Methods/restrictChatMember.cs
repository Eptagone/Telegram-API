// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool RestrictChatMember(this BotClient bot, RestrictChatMemberArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<bool>("restrictChatMember", args);
        }
        /// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="permissions">New user permissions.</param>
        /// <param name="until_date">Optional. Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool RestrictChatMember(this BotClient bot, long chat_id, int user_id, Available_Types.ChatPermissions permissions, [Optional] uint until_date)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new RestrictChatMemberArgs
            {
                Chat_id = chat_id,
                User_id = user_id,
                Permissions = permissions
            };
            if (until_date != default)
            {
                args.Until_date = until_date;
            }

            return bot.RPC<bool>("restrictChatMember", args);
        }
        /// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> RestrictChatMemberAsync(this BotClient bot, RestrictChatMemberArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<bool>("restrictChatMember", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="permissions">New user permissions.</param>
        /// <param name="until_date">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> RestrictChatMemberAsync(this BotClient bot, object chat_id, int user_id, Available_Types.ChatPermissions permissions, [Optional] uint until_date, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new RestrictChatMemberArgs
            {
                Chat_id = chat_id,
                User_id = user_id,
                Permissions = permissions
            };
            if (until_date != default)
            {
                args.Until_date = until_date;
            }

            return await bot.RPCA<bool>("restrictChatMember", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}