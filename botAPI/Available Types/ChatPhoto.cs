using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a chat photo.</summary>
    public class ChatPhoto
    {
        /// <summary>Unique file identifier of small (160x160) chat photo. This file_id can be used only for photo download.</summary>
        [JsonProperty(PropertyName = "small_file_id", Required = Required.Always)]
        public string Small_file_id { get; set; }
        /// <summary>Unique file identifier of big (640x640) chat photo. This file_id can be used only for photo download.</summary>
        [JsonProperty(PropertyName = "big_file_id", Required = Required.Always)]
        public string Big_file_id { get; set; }
    }
}