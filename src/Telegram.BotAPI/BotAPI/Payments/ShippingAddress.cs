// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents a shipping address.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ShippingAddress
    {
        /// <summary>ISO 3166-1 alpha-2 country code</summary>
        [JsonPropertyName("country_code")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country_code { get; set; }
        /// <summary>State, if applicable</summary>
        [JsonPropertyName("state")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        /// <summary>City</summary>
        [JsonPropertyName("city")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        /// <summary>First line for the address</summary>
        [JsonPropertyName("street_line1")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street_line1 { get; set; }
        /// <summary>Second line for the address</summary>
        [JsonPropertyName("street_line2")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street_line2 { get; set; }
        /// <summary>Address post code</summary>
        [JsonPropertyName("post_code")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Post_code { get; set; }
    }
}
