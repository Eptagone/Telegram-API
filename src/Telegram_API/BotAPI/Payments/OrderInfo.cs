// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Payments
{
    /// <summary>This object represents information about an order.</summary>
    public class OrderInfo
    {
        /// <summary>Optional. User name</summary>
        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>Optional. User's phone number</summary>
        [JsonProperty(PropertyName = "phone_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_number { get; set; }
        /// <summary>Optional. User email</summary>
        [JsonProperty(PropertyName = "email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        /// <summary>Optional. User shipping address</summary>
        [JsonProperty(PropertyName = "shipping_address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingAddress Shipping_address { get; set; }
    }
}
