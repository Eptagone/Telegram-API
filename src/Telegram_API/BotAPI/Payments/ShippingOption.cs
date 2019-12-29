// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Payments
{
    /// <summary>This object represents one shipping option.</summary>
    public class ShippingOption
    {
        /// <summary>Shipping option identifier</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }
        /// <summary>Option title</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
        /// <summary>List of price portions</summary>
        [JsonProperty(PropertyName = "prices", Required = Required.Always)]
        public LabeledPrice[] Prices { get; set; }
    }
}
