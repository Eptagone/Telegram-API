// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object contains information about one answer option in a poll.</summary>
    public sealed class PollOption
    {
        /// <summary>Option text, 1-100 characters.</summary>
        [JsonPropertyName("test")]
        public string Text { get; set; }
        /// <summary>Number of users that voted for this option.</summary>
        [JsonPropertyName("voter_count")]
        public uint Voter_count { get; set; }
    }
}
