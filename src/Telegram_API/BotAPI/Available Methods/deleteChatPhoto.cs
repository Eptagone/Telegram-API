// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to delete a chat photo. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        public static bool DeleteChatPhoto(this BotClient T, object chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("deleteChatPhoto", new JObject { new JProperty("chat_id", chat_id) });
        }
        /// <summary>Use this method to delete a chat photo. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        public static async Task<bool> DeleteChatPhotoAsync(this BotClient T, object chat_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("deleteChatPhoto", new JObject { new JProperty("chat_id", chat_id) }).ConfigureAwait(true);
        }
    }
}