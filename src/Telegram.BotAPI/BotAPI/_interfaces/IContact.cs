// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a phone contact.</summary>
    public interface IContact
    {
        /// <summary>Contact's phone number.</summary>
        public string Phone_number { get; set; }
        /// <summary>Contact's first name.</summary>
        public string First_name { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        public string Last_name { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
        public string Vcard { get; set; }
    }
}