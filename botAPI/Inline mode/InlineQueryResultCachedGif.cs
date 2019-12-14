using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to an animated GIF file stored on the Telegram servers. By default, this animated GIF file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with specified content instead of the animation.</summary>
    public class InlineQueryResultCachedGif : InlineQueryResult
    {
        /// <summary>Type of the result, must be gif.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "gif";
        /// <summary>A valid file identifier for the GIF file..</summary>
        [JsonProperty(PropertyName = "gif_file_id", Required = Required.Always)]
        public string Gif_file_id { get; set; }
        ///<summary>Optional. Caption of the GIF file to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
    }
}
