// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a dice with random value from 1 to 6. (Yes, we're aware of the “proper” singular of die. But it's awkward, and we decided to help it change. One dice at a time!)</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Dice
    {
        /// <summary>Value of the dice, 1-6</summary>
        [JsonPropertyName("Value")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Value { get; set; }
    }
}
