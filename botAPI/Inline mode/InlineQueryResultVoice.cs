using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a voice recording in an .ogg container encoded with OPUS. By default, this voice recording will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the the voice message.</summary>
    public class InlineQueryResultVoice : InlineQueryResult
    {
        /// <summary>Type of the result, must be voice.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "voice";
        ///<summary>A valid URL for the voice recording.</summary>
        [JsonProperty(PropertyName = "voice_url", Required = Required.Always)]
        public string Voice_url { get; set; }
        ///<summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Recording duration in seconds.</summary>
        [JsonProperty(PropertyName = "voice_duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Voice_duration { get; set; }
    }
}
