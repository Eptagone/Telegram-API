// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a phone contact..</summary>
    public sealed class Contact
    {
        /// <summary>Contact's phone number.</summary>
        [JsonPropertyName("phone_number")]
        public string Phone_number { get; set; }
        /// <summary>Contact's first name.</summary>
        [JsonPropertyName("first_name")]
        public string First_name { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        [JsonPropertyName("last_name")]
        public string Last_name { get; set; }
        /// <summary>Optional. Contact's user identifier in Telegram.</summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
        [JsonPropertyName("vcard")]
        public string Vcard { get; set; }
    }
}