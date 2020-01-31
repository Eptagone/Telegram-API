// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents one shipping option.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ShippingOption
    {
        /// <summary>Shipping option identifier</summary>
        [JsonPropertyName("id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Option title</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>List of price portions</summary>
        [JsonPropertyName("prices")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LabeledPrice[] Prices { get; set; }
    }
}
