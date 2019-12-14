using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to get the number of members in a chat. Returns Int on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        public static uint GetChatMembersCount(this BotClient T, object chat_id) => T.RPC<uint>("getChatMembersCount", new JObject { new JProperty("chat_id", chat_id) });
    }
}