// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    /// <summary>Available Methods</summary>
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message ForwardMessage(this BotClient T, object chat_id, object from_chat_id, uint message_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Message>("forwardMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("from_chat_id", from_chat_id), new JProperty("message_id", message_id) });
        }

        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message ForwardMessage(this BotClient T, object chat_id, object from_chat_id, uint message_id, bool disable_notification)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Message>("forwardMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("from_chat_id", from_chat_id), new JProperty("disable_notification", disable_notification), new JProperty("message_id", message_id) });
        }
    }
}