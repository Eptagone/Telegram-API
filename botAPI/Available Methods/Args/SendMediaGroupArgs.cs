using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendMediaGroud method arguments.</summary>
    public class SendMediaGroupArgs
    {
        ///<summary>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "chat_id", Required = Required.Always)]
        public object Chat_id { get; set; }
        ///<summary>A JSON array of <see cref="Available_Types.InputMedia"/> and <see cref="Available_Types.InputMedia"/>, describing photos and videos to be sent, must include 2–10 items.</summary>
        [JsonProperty(PropertyName = "media", Required = Required.Always)]
        public Available_Types.InputMedia[] Media { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonProperty(PropertyName = "disable_notification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonProperty(PropertyName = "reply_to_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Reply_to_message_id { get; set; }
    }
}