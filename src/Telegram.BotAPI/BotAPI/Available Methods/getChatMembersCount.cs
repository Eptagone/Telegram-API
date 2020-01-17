// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        public static uint GetChatMembersCount(this BotClient T, object chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<uint>("getChatMembersCount", new JObject { new JProperty("chat_id", chat_id) });
        }
        /// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        public static async Task<uint> GetChatMembersCountAsync(this BotClient T, object chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<uint>("getChatMembersCount", new JObject { new JProperty("chat_id", chat_id) }).ConfigureAwait(true);
        }
    }
}