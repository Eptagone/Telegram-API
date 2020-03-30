// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a bot command.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotCommand
    {
        /// <summary>Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</summary>
        [JsonPropertyName("command")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Command { get; set; }
        /// <summary>Description of the command, 3-256 characters.</summary>
        [JsonPropertyName("description")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}
