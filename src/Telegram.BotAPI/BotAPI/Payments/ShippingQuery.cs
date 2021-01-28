// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains information about an incoming shipping query.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ShippingQuery
    {
        /// <summary>Unique query identifier</summary>
        [JsonPropertyName("id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonPropertyName("from")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvailableTypes.User From { get; set; }
        /// <summary>Bot specified invoice payload</summary>
        [JsonPropertyName("invoice_payload")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Invoice_payload { get; set; }
        /// <summary>User specified shipping address</summary>
        [JsonPropertyName("shipping_address")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingAddress Shipping_address { get; set; }
    }
}