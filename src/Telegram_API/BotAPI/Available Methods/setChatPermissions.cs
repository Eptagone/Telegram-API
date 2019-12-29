// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        public static bool SetChatPermissions(this BotClient T, object chat_id, Available_Types.ChatPermissions permissions) => T.RPC<bool>("setChatPermissions", new JObject { new JProperty("chat_id", chat_id), new JProperty("permissions", permissions) });
    }
}
