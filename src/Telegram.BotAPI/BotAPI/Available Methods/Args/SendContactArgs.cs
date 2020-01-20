﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendContact method arguments.</summary>
    public sealed class SendContactArgs : BaseSendArgs
    {
        ///<summary>Contact's phone number.</summary>
        [JsonPropertyName("phone_number")]
        public string Phone_number { get; set; }
        /// <summary>Contact's first name.</summary>
        [JsonPropertyName("first_name")]
        public string First_name { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        [JsonPropertyName("last_name")]
        public string Last_name { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes.</summary>
        [JsonPropertyName("vcard")]
        public string Vcard { get; set; }
    }
}