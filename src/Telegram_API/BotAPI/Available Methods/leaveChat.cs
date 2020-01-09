// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        public static bool LeaveChat(this BotClient T, object chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("leaveChat", new JObject { new JProperty("chat_id", chat_id) });
        }
        /// <summary>Use this method for your bot to leave a group, supergroup or channel. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        public static async Task<bool> LeaveChatAsync(this BotClient T, object chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("leaveChat", new JObject { new JProperty("chat_id", chat_id) }).ConfigureAwait(true);
        }
    }
}