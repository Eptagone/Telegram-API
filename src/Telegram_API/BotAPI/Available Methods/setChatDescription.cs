﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to change the description of a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="description">New chat description, 0-255 characters.</param>
        public static bool SetChatDescription(this BotClient T, long chat_id, string description)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setChatDescription", new JObject { new JProperty("chat_id", chat_id), new JProperty("description", description) });
        }
        /// <summary>Use this method to change the description of a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="description">New chat description, 0-255 characters.</param>
        public static bool SetChatDescription(this BotClient T, string chat_id, string description)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setChatDescription", new JObject { new JProperty("chat_id", chat_id), new JProperty("description", description) });
        }
        /// <summary>Use this method to change the description of a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="description">New chat description, 0-255 characters.</param>
        public static async Task<bool> SetChatDescriptionAsync(this BotClient T, long chat_id, string description)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setChatDescription", new JObject { new JProperty("chat_id", chat_id), new JProperty("description", description) }).ConfigureAwait(true);
        }
        /// <summary>Use this method to change the description of a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="description">New chat description, 0-255 characters.</param>
        public static async Task<bool> SetChatDescriptionAsync(this BotClient T, string chat_id, string description)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setChatDescription", new JObject { new JProperty("chat_id", chat_id), new JProperty("description", description) }).ConfigureAwait(true);
        }
    }
}