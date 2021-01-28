// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object contains information about one answer option in a poll.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PollOption
    {
        /// <summary>Option text, 1-100 characters.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>Number of users that voted for this option.</summary>
        [JsonPropertyName(PropertyNames.VoterCount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint VoterCount { get; set; }
    }
}
