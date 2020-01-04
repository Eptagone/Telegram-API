using Newtonsoft.Json;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SetChatPhoto method arguments.</summary>
    public sealed class SetChatPhotoArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonProperty("chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        /// <summary>New chat photo, uploaded using multipart/form-data.</summary>
        [InputFile("photo")]
        [JsonProperty("photo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile Photo { get; set; }
    }
}
