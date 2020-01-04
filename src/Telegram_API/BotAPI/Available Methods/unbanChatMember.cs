// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group or username of the target supergroup or channel (in the format @username).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        public static bool UnbanChatMember(this BotClient T, object chat_id, int user_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("unbanChatMember", new JObject { new JProperty("chat_id", chat_id), new JProperty("user_id", user_id) });
        }
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target group, supergroup or channel.</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        public static bool UnbanChatMember(this BotClient T, long chat_id, int user_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("unbanChatMember", new JObject { new JProperty("chat_id", chat_id), new JProperty("user_id", user_id) });
        }
        /// <summary>Use this method to unban a previously kicked user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique username of the target supergroup or channel.</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        public static bool UnbanChatMember(this BotClient T, string chat_id, int user_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("unbanChatMember", new JObject { new JProperty("chat_id", chat_id), new JProperty("user_id", user_id) });
        }
    }
}