﻿using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to pin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="message_id">Identifier of a message to pin.</param>
        public static bool PinChatMessage(this BotClient T, object chat_id, int message_id) => T.RPC<bool>("pinChatMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id) });
        /// <summary>Use this method to pin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="message_id">Identifier of a message to pin.</param>
        /// <param name="disable_notification">Optional. Pass True, if it is not necessary to send a notification to all chat members about the new pinned message. Notifications are always disabled in channels.</param>
        public static bool PinChatMessage(this BotClient T, object chat_id, int message_id, bool disable_notification) => T.RPC<bool>("pinChatMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id), new JProperty("disable_notification", disable_notification) });
    }
}