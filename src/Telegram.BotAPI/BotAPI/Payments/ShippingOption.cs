// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents one shipping option.</summary>
    public sealed class ShippingOption
    {
        /// <summary>Shipping option identifier</summary>
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Option title</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>List of price portions</summary>
        [JsonProperty(PropertyName = "prices", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LabeledPrice[] Prices { get; set; }
    }
}
