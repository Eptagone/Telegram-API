﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the location.</summary>
    public sealed class InlineQueryResultLocation : InlineQueryResult
    {
        /// <summary>Type of the result, must be location.</summary>
        [JsonPropertyName("type")]
        public override string Type => "location";
        /// <summary>Location latitude in degrees.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        /// <summary>Location longitude in degrees.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        /// <summary>Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.</summary>
        [JsonPropertyName("live_period")]
        public uint Live_period { get; set; }
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        [JsonPropertyName("thumb_url")]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonPropertyName("thumb_width")]
        public uint Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName("thumb_height")]
        public uint Thumb_height { get; set; }
    }
}