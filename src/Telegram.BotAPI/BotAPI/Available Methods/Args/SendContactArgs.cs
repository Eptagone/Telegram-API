// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendContact method arguments.</summary>
    public sealed class SendContactArgs : BaseSendArgs
    {
        ///<summary>Contact's phone number.</summary>
        [JsonProperty(PropertyName = "phone_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_number { get; set; }
        /// <summary>Contact's first name.</summary>
        [JsonProperty(PropertyName = "first_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First_name { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        [JsonProperty(PropertyName = "last_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_name { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes.</summary>
        [JsonProperty(PropertyName = "vcard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Vcard { get; set; }
    }
}