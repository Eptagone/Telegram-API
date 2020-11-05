// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the venue.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultVenue : InlineQueryResult, IInlineQueryResult, IVenue, IThumbUWH
    {
        /// <summary>Type of the result, must be venue.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "venue";
        /// <summary>Latitude of the venue location in degrees.</summary>
        [JsonPropertyName("latitude")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        /// <summary>Longitude of the venue location in degrees.</summary>
        [JsonPropertyName("longitude")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Title of the venue.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonPropertyName("address")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue if known.</summary>
        [JsonPropertyName("foursquare_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonPropertyName("foursquare_type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
        ///<summary>Optional. Google Places identifier of the venue.</summary>
        [JsonPropertyName("google_place_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Google_place_id { get; set; }
        ///<summary>Optional. Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)</summary>
        [JsonPropertyName("google_place_type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Google_place_type { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the venue.</summary>
        [JsonPropertyName("input_message_content")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent Input_message_content { get; set; }
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        [JsonPropertyName("thumb_url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonPropertyName("thumb_width")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName("thumb_height")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_height { get; set; }
    }
}
