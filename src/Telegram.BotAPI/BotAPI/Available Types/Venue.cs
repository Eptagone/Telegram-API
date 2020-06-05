﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents a venue.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Venue
    {
        ///<summary>Venue location.</summary>
        [JsonPropertyName("location")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonPropertyName("address")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue.</summary>
        [JsonPropertyName("foursquare_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonPropertyName("foursquare_type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
    }
}