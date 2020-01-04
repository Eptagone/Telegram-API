// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to get information about a member of a chat. Returns a ChatMember object on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <returns><see cref="Available_Types.ChatMember"/></returns>
        public static Available_Types.ChatMember GetChatMember(this BotClient T, object chat_id, int user_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.ChatMember>("getChatMember", new JObject { new JProperty("chat_id", chat_id), new JProperty("user_id", user_id) });
        }
    }
}