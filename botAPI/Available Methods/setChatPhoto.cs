using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to set a new profile photo for the chat. Photos can't be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="photo">New chat photo, uploaded using multipart/form-data.</param>
        public static bool SetChatPhoto(this BotClient T, object chat_id, object photo) => T.RPC<bool>("setChatPhoto", new JObject { new JProperty("chat_id", chat_id), new JProperty("photo", photo) });
    }
}