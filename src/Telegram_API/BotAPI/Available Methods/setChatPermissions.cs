// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        public static bool SetChatPermissions(this BotClient T, long chat_id, Available_Types.ChatPermissions permissions)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setChatPermissions", new JObject { new JProperty("chat_id", chat_id), new JProperty("permissions", permissions) });
        }
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        public static bool SetChatPermissions(this BotClient T, string chat_id, Available_Types.ChatPermissions permissions)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setChatPermissions", new JObject { new JProperty("chat_id", chat_id), new JProperty("permissions", permissions) });
        }
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        public static async Task<bool> SetChatPermissionsAsync(this BotClient T, long chat_id, Available_Types.ChatPermissions permissions)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setChatPermissions", new JObject { new JProperty("chat_id", chat_id), new JProperty("permissions", permissions) }).ConfigureAwait(true);
        }
        /// <summary>Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="permissions">New default chat permissions.</param>
        public static async Task<bool> SetChatPermissionsAsync(this BotClient T, string chat_id, Available_Types.ChatPermissions permissions)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setChatPermissions", new JObject { new JProperty("chat_id", chat_id), new JProperty("permissions", permissions) }).ConfigureAwait(true);
        }
    }
}
