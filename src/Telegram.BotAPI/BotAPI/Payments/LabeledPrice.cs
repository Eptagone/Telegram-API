// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents a portion of the price for goods or services.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class LabeledPrice
    {
        /// <summary>Portion label.</summary>
        [JsonPropertyName(PropertyNames.Label)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Label { get; set; }
        /// <summary>Price of the product in the smallest units of the <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonPropertyName(PropertyNames.Amount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Amount { get; set; }
    }
}
