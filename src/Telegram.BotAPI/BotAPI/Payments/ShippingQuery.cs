// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains information about an incoming shipping query.</summary>
    public sealed class ShippingQuery
    {
        /// <summary>Unique query identifier</summary>
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonProperty(PropertyName = "from", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.User From { get; set; }
        /// <summary>Bot specified invoice payload</summary>
        [JsonProperty(PropertyName = "invoice_payload", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Invoice_payload { get; set; }
        /// <summary>User specified shipping address</summary>
        [JsonProperty(PropertyName = "shipping_address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingAddress Shipping_address { get; set; }
    }
}