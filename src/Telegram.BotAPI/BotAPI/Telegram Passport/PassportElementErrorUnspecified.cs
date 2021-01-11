// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue in an unspecified place. The error is considered resolved when new data is added.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportElementErrorUnspecified : PassportElementError
    {
        /// <summary>Error source, must be unspecified.</summary>
        [JsonPropertyName("source")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => "unspecified";
        /// <summary>Type of element of the user's Telegram Passport which has the issue.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded element hash.</summary>
        [JsonPropertyName("element_hash")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Element_hash { get; set; }
    }
}
