using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a photo. By default, this photo will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the photo.</summary>
    public class InlineQueryResultPhoto : InlineQueryResult
    {
        /// <summary>Type of the result, must be photo.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "photo";
        /// <summary>A valid URL of the photo. Photo must be in jpeg format. Photo size must not exceed 5MB.</summary>
        [JsonProperty(PropertyName = "photo_url", Required = Required.Always)]
        public string Photo_url { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonProperty(PropertyName = "thumb_url", Required = Required.Always)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Width of the photo.</summary>
        [JsonProperty(PropertyName = "photo_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Photo_width { get; set; }
        /// <summary>Optional. Height of the photo.</summary>
        [JsonProperty(PropertyName = "photo_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Photo_height { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        ///<summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
    }
}