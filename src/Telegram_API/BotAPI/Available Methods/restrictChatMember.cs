// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="permissions">New user permissions.</param>
        /// <param name="until_date">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</param>
        public static bool RestrictChatMember(this BotClient T, object chat_id, int user_id, Available_Types.ChatPermissions permissions, uint until_date = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new JObject { new JProperty("chat_id", chat_id), new JProperty("user_id", user_id), new JProperty("permissions", permissions) };
            if (until_date != default)
                args.Add("until_date", until_date);
            return T.RPC<bool>("restrictChatMember", args);
        }
        /// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="permissions">New user permissions.</param>
        /// <param name="until_date">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</param>
        public static async Task<bool> RestrictChatMemberAsync(this BotClient T, object chat_id, int user_id, Available_Types.ChatPermissions permissions, uint until_date = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new JObject { new JProperty("chat_id", chat_id), new JProperty("user_id", user_id), new JProperty("permissions", permissions) };
            if (until_date != default)
                args.Add("until_date", until_date);
            return await T.RPCA<bool>("restrictChatMember", args).ConfigureAwait(true);
        }
    }
}