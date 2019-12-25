// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Payments
{
    /// <summary>This object contains information about an incoming shipping query.</summary>
    public class ShippingQuery
    {
        /// <summary>Unique query identifier</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonProperty(PropertyName = "from", Required = Required.Always)]
        public Available_Types.User From { get; set; }
        /// <summary>Bot specified invoice payload</summary>
        [JsonProperty(PropertyName = "invoice_payload", Required = Required.Always)]
        public string Invoice_payload { get; set; }
        /// <summary>User specified shipping address</summary>
        [JsonProperty(PropertyName = "shipping_address", Required = Required.Always)]
        public ShippingAddress Shipping_address { get; set; }
    }
}