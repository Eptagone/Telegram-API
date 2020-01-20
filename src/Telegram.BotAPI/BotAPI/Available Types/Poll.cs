// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object contains information about a poll.</summary>
    public sealed class Poll
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>Poll question, 1-255 characters.</summary>
        [JsonPropertyName("question")]
        public string Question { get; set; }
        /// <summary>List of poll options.</summary>
        [JsonPropertyName("options")]
        public PollOption[] Options { get; set; }
        /// <summary>True, if the poll is closed.</summary>
        [JsonPropertyName("is_closed")]
        public bool Is_closed { get; set; }
    }
}
