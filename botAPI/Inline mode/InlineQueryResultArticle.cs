using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to an article or web page.</summary>
    public class InlineQueryResultArticle : InlineQueryResult
    {
        /// <summary>Type of the result, must be article.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "article";
        /// <summary>Optional. URL of the result.</summary>
        [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        /// <summary>Optional. Pass True, if you don't want the URL to be shown in the message.</summary>
        [JsonProperty(PropertyName = "hide_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Hide_url { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonProperty(PropertyName = "thumb_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonProperty(PropertyName = "thumb_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Thumb_height { get; set; }
    }
}