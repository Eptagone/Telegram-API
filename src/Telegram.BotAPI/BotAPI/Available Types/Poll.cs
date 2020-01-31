// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object contains information about a poll.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Poll
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonPropertyName("id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Poll question, 1-255 characters.</summary>
        [JsonPropertyName("question")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Question { get; set; }
        /// <summary>List of poll options.</summary>
        [JsonPropertyName("options")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PollOption[] Options { get; set; }
        /// <summary>Total number of users that voted in the poll.</summary>
        [JsonPropertyName("total_voter_count")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Total_voter_count { get; set; }
        /// <summary>True, if the poll is closed.</summary>
        [JsonPropertyName("is_closed")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_closed { get; set; }
        /// <summary>True, if the poll is anonymous.</summary>
        [JsonPropertyName("is_anonymous")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_anonymous { get; set; }
        /// <summary>Poll type, currently can be “regular” or “quiz”.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        /// <summary>True, if the poll allows multiple answers.</summary>
        [JsonPropertyName("allows_multiple_answers")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Allows_multiple_answers { get; set; }
        /// <summary>Optional. 0-based identifier of the correct answer option. Available only for polls in the quiz mode, which are closed, or was sent (not forwarded) by the bot or to the private chat with the bot.</summary>
        [JsonPropertyName("correct_option_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Correct_option_id { get; set; }
    }
}
