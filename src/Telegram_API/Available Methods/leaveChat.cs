// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        public static bool LeaveChat(this BotClient T, object chat_id) => T.RPC<bool>("leaveChat", new JObject { new JProperty("chat_id", chat_id) });
    }
}