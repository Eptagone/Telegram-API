using Newtonsoft.Json.Linq;

namespace TelegramAPI.Updating_messages
{
    public static partial class Updating_messages
    {
        /// <summary>Use this method to delete a message, including service messages, with the following limitations: <br/>
        /// - A message can only be deleted if it was sent less than 48 hours ago.<br/>
        /// - Bots can delete outgoing messages in private chats, groups, and supergroups.<br/>
        /// - Bots can delete incoming messages in private chats.<br/>
        /// - Bots granted can_post_messages permissions can delete outgoing messages in channels.<br/>
        /// - If the bot is an administrator of a group, it can delete any message there.<br/>
        /// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.<br/>
        /// Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="message_id">Identifier of the message to delete.</param>
        public static bool DeleteMessage(this BotClient T, object chat_id, int message_id) => T.RPC<bool>("deleteMessage", new JObject { new JProperty("chat_id", chat_id), new JProperty("message_id", message_id) });
    }
}