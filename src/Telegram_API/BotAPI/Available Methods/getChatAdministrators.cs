// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to get a list of administrators in a chat. On success, returns an Array of ChatMember objects that contains information about all chat administrators except other bots. If the chat is a group or a supergroup and no administrators were appointed, only the creator will be returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <returns>Array de ChatMember Object.</returns>
        public static Available_Types.ChatMember[] GetChatAdministrators(this BotClient T, object chat_id) => T.RPC<Available_Types.ChatMember[]>("getChatAdministrators", new JObject { new JProperty("chat_id", chat_id) });
    }
}