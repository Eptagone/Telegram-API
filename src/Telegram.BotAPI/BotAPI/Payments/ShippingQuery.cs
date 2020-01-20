// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains information about an incoming shipping query.</summary>
    public sealed class ShippingQuery
    {
        /// <summary>Unique query identifier</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonPropertyName("from")]
        public Available_Types.User From { get; set; }
        /// <summary>Bot specified invoice payload</summary>
        [JsonPropertyName("invoice_payload")]
        public string Invoice_payload { get; set; }
        /// <summary>User specified shipping address</summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress Shipping_address { get; set; }
    }
}