// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents an answer of a user in a non-anonymous poll.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptOut, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PollAnswer
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonPropertyName(PropertyNames.PollId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PollId { get; set; }
        /// <summary>The user, who changed the answer to the poll.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        /// <summary>0-based identifiers of answer options, chosen by the user. May be empty if the user retracted their vote.</summary>
        [JsonPropertyName(PropertyNames.OptionIds)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<uint> OptionIds { get; set; }
    }
}
