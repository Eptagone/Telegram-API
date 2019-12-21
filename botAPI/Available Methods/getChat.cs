using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to get up to date information about the chat (current name of the user for one-on-one conversations, current username of a user, group or channel, etc.). Returns a Chat object on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <returns>Chat Object.</returns>
        public static Available_Types.Chat GetChat(this BotClient T, string chat_id) => T.RPC<Available_Types.Chat>("getChat", new JObject { new JProperty("chat_id", chat_id) });
        /// <summary>Use this method to get up to date information about the chat (current name of the user for one-on-one conversations, current username of a user, group or channel, etc.). Returns a Chat object on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <returns>Chat Object.</returns>
        public static Available_Types.Chat GetChat(this BotClient T, long chat_id) => T.RPC<Available_Types.Chat>("getChat", new JObject { new JProperty("chat_id", chat_id) });
    }
}