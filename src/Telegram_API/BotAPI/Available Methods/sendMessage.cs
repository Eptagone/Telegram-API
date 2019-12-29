// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message SendMessage(this BotClient T, SendMessageArgs args) => T.RPC<Available_Types.Message>("sendMessage", args);
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message SendMessage(this BotClient T, object chat_id, string text) => T.RPC<Available_Types.Message>("sendMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("text", text) });
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="reply_to_message_id">If the message is a reply, ID of the original message.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message SendMessage(this BotClient T, object chat_id, string text, uint reply_to_message_id) => T.RPC<Available_Types.Message>("sendMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("text", text), new JProperty("reply_to_message_id", reply_to_message_id) });
    }
}