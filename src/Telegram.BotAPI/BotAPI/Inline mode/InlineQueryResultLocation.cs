// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the location.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultLocation : InlineQueryResultWithEntities, ILocation, IInlineQueryResult, IThumbUWH
    {
        /// <summary>Type of the result, must be location.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "location";
        ///<summary>Longitude as defined by sender.</summary>
        [JsonPropertyName("longitude")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        [JsonPropertyName("latitude")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        /// <summary>Title of the result.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
        [JsonPropertyName("horizontal_accuracy")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Horizontal_accuracy { get; set; }
        ///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
        [JsonPropertyName("live_period")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Live_period { get; set; }
        ///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
        [JsonPropertyName("heading")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Heading { get; set; }
        ///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
        [JsonPropertyName("proximity_alert_radius")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Proximity_alert_radius { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the location.</summary>
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
