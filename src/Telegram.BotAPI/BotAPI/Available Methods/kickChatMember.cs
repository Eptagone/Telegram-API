// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
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
        public static bool KickChatMember(this BotClient T, object chat_id, int user_id, int until_date = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new JObject {
                new JProperty("chat_id", chat_id),
                new JProperty("user_id", user_id)
            };
            if (until_date != default)
                args.Add("until_date", until_date);
            return T.RPC<bool>("kickChatMember", args);
        }
        /// <summary>Use this method to kick a user from a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the group on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @channelusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// /// <param name="until_date">Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        public static async Task<bool> KickChatMemberAsync(this BotClient T, object chat_id, int user_id, int until_date = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new JObject {
                new JProperty("chat_id", chat_id),
                new JProperty("user_id", user_id)
            };
            if (until_date != default)
                args.Add("until_date", until_date);
            return await T.RPCA<bool>("kickChatMember", args).ConfigureAwait(true);
        }
    }
}