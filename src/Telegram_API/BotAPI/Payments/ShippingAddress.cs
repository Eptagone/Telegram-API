// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Payments
{
    /// <summary>This object represents a shipping address.</summary>
    public sealed class ShippingAddress
    {
        /// <summary>ISO 3166-1 alpha-2 country code</summary>
        [JsonProperty(PropertyName = "country_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country_code { get; set; }
        /// <summary>State, if applicable</summary>
        [JsonProperty(PropertyName = "state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        /// <summary>City</summary>
        [JsonProperty(PropertyName = "city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        /// <summary>First line for the address</summary>
        [JsonProperty(PropertyName = "street_line1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street_line1 { get; set; }
        /// <summary>Second line for the address</summary>
        [JsonProperty(PropertyName = "street_line2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street_line2 { get; set; }
        /// <summary>Address post code</summary>
        [JsonProperty(PropertyName = "post_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Post_code { get; set; }
    }
}
