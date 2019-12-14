using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the venue.</summary>
    public class InlineQueryResultVenue : InlineQueryResult
    {
        /// <summary>Type of the result, must be venue.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "venue";
        /// <summary>Latitude of the venue location in degrees.</summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude { get; set; }
        /// <summary>Longitude of the venue location in degrees.</summary>
        [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
        public float Longitude { get; set; }
        /// <summary>Title of the venue.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public new string Title { get; set; }
        /// <summary>Address of the venue.</summary>
        [JsonProperty(PropertyName = "address", Required = Required.Always)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue if known.</summary>
        [JsonProperty(PropertyName = "foursquare_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonProperty(PropertyName = "foursquare_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the venue.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
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
