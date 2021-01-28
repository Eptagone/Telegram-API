// Copyright (c) 2021 Quetzal Rivera.
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
        [JsonPropertyName(PropertyNames.CountryCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCode { get; set; }
        /// <summary>State, if applicable</summary>
        [JsonPropertyName(PropertyNames.State)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        /// <summary>City</summary>
        [JsonPropertyName(PropertyNames.City)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        /// <summary>First line for the address</summary>
        [JsonPropertyName(PropertyNames.StreetLine1)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetLine1 { get; set; }
        /// <summary>Second line for the address</summary>
        [JsonPropertyName(PropertyNames.StreetLine2)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetLine2 { get; set; }
        /// <summary>Address post code</summary>
        [JsonPropertyName(PropertyNames.PostCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PostCode { get; set; }
    }
}
