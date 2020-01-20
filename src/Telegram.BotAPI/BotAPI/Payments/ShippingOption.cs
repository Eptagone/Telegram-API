// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents one shipping option.</summary>
    public sealed class ShippingOption
    {
        /// <summary>Shipping option identifier</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>Option title</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>List of price portions</summary>
        [JsonPropertyName("prices")]
        public LabeledPrice[] Prices { get; set; }
    }
}
