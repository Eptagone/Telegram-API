// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static bool SetChatTitle(this BotClient T, long chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setChatTitle", new JObject { new JProperty("chat_id", chat_id), new JProperty("title", title) });
        }
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static bool SetChatTitle(this BotClient T, string chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setChatTitle", new JObject { new JProperty("chat_id", chat_id), new JProperty("title", title) });
        }
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static async Task<bool> SetChatTitleAsync(this BotClient T, long chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setChatTitle", new JObject { new JProperty("chat_id", chat_id), new JProperty("title", title) }).ConfigureAwait(true);
        }
        /// <summary>Use this method to change the title of a chat. Titles can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="title">New chat title, 1-255 characters.</param>
        public static async Task<bool> SetChatTitleAsync(this BotClient T, string chat_id, string title)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setChatTitle", new JObject { new JProperty("chat_id", chat_id), new JProperty("title", title) }).ConfigureAwait(true);
        }
    }
}