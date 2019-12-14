using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a video file stored on the Telegram servers. By default, this video file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the video.</summary>
    public class InlineQueryResultCachedVideo : InlineQueryResult
    {
        /// <summary>Type of the result, must be video.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "video";
        /// <summary>A valid file identifier for the video file.</summary>
        [JsonProperty(PropertyName = "video_file_id", Required = Required.Always)]
        public string Video_file_id { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", Required = Required.Always)]
        public string Description { get; set; }
        /// <summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", Required = Required.Always)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption..</summary>
        [JsonProperty(PropertyName = "parse_mode", Required = Required.Always)]
        public string Parse_mode { get; set; }
    }
}
