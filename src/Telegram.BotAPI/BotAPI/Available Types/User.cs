// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a Telegram user or bot.</summary>
    public sealed class User
    {
        /// <summary>Unique identifier for this user or bot.</summary>
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
        /// <summary>True, if this user is a bot.</summary>
        [JsonProperty(PropertyName = "is_bot", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_bot { get; set; }
        /// <summary>User‘s or bot’s first name.</summary>
        [JsonProperty(PropertyName = "first_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First_name { get; set; }
        /// <summary>Optional. User‘s or bot’s last name.</summary>
        [JsonProperty(PropertyName = "last_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_name { get; set; }
        /// <summary>Optional. User‘s or bot’s username.</summary>
        [JsonProperty(PropertyName = "username", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }
        /// <summary>Optional. IETF language tag of the user's language.</summary>
        [JsonProperty(PropertyName = "language_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Language_code { get; set; }
    }
}