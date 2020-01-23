// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents an answer of a user in a non-anonymous poll.</summary>
    public class PollAnswer
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonPropertyName("poll_id")]
        public string Poll_id { get; set; }
        /// <summary>The user, who changed the answer to the poll.</summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
        /// <summary>0-based identifiers of answer options, chosen by the user. May be empty if the user retracted their vote.</summary>
        [JsonPropertyName("option_ids")]
        public uint[] Option_ids { get; set; }
    }
}
