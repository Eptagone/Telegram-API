// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a Telegram user or bot.</summary>
    public sealed class User
    {
        /// <summary>Unique identifier for this user or bot.</summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>True, if this user is a bot.</summary>
        [JsonPropertyName("is_bot")]
        public bool Is_bot { get; set; }
        /// <summary>User‘s or bot’s first name.</summary>
        [JsonPropertyName("first_name")]
        public string First_name { get; set; }
        /// <summary>Optional. User‘s or bot’s last name.</summary>
        [JsonPropertyName("last_name")]
        public string Last_name { get; set; }
        /// <summary>Optional. User‘s or bot’s username.</summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
        /// <summary>Optional. IETF language tag of the user's language.</summary>
        [JsonPropertyName("language_code")]
        public string Language_code { get; set; }
    }
}