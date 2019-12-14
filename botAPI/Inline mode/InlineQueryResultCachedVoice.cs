using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a voice message stored on the Telegram servers. By default, this voice message will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the voice message.</summary>
    public class InlineQueryResultCachedVoice : InlineQueryResult
    {
        /// <summary>Type of the result, must be voice</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "voice";
        /// <summary>A valid file identifier for the voice message.</summary>
        [JsonProperty(PropertyName = "voice_file_id", Required = Required.Always)]
        public string Voice_file_id { get; set; }
        /// <summary>Voice message title.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public new string Title { get; set; }
        /// <summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", Required = Required.Always)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption..</summary>
        [JsonProperty(PropertyName = "parse_mode", Required = Required.Always)]
        public string Parse_mode { get; set; }
    }
}
