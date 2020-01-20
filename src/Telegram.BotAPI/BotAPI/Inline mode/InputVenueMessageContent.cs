﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents the content of a venue message to be sent as the result of an inline query.</summary>
    public sealed class InputVenueMessageContent : InputMessageContent
    {
        ///<summary>Latitude of the venue in degrees.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        ///<summary>Longitude of the venue in degrees.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue, if known.</summary>
        [JsonPropertyName("foursquare_id")]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonPropertyName("foursquare_type")]
        public string Foursquare_type { get; set; }
    }
}
