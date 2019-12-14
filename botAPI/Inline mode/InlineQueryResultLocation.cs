using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the location.</summary>
    public class InlineQueryResultLocation : InlineQueryResult
    {
        /// <summary>Type of the result, must be location.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "location";
        /// <summary>Location latitude in degrees.</summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude { get; set; }
        /// <summary>Location longitude in degrees.</summary>
        [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
        public float Longitude { get; set; }
        /// <summary>Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.</summary>
        [JsonProperty(PropertyName = "live_period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Live_period { get; set; }
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonProperty(PropertyName = "thumb_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonProperty(PropertyName = "thumb_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_height { get; set; }
    }
}
