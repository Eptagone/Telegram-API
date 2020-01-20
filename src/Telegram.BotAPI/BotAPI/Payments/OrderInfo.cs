// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents information about an order.</summary>
    public sealed class OrderInfo
    {
        /// <summary>Optional. User name</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        /// <summary>Optional. User's phone number</summary>
        [JsonPropertyName("phone_number")]
        public string Phone_number { get; set; }
        /// <summary>Optional. User email</summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
        /// <summary>Optional. User shipping address</summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress Shipping_address { get; set; }
    }
}
