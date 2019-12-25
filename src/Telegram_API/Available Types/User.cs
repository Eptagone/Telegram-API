// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a Telegram user or bot.</summary>
    public class User
    {
        /// <summary>Unique identifier for this user or bot.</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public int Id { get; set; }
        /// <summary>True, if this user is a bot.</summary>
        [JsonProperty(PropertyName = "is_bot", Required = Required.Always)]
        public bool Is_bot { get; set; }
        /// <summary>User‘s or bot’s first name.</summary>
        [JsonProperty(PropertyName = "first_name", Required = Required.Always)]
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