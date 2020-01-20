// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.</summary>
    public sealed class PassportElementErrorDataField : PassportElementError
    {
        /// <summary>Error source, must be data.</summary>
        [JsonPropertyName("source")]
        public override string Source => "data";
        /// <summary>The section of the user's Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”.</summary>
        [JsonPropertyName("type")]
        public override string Type { get; set; }
        /// <summary>Name of the data field which has the error.</summary>
        [JsonPropertyName("field_name")]
        public string Field_name { get; set; }
        /// <summary>Base64-encoded data hash.</summary>
        [JsonPropertyName("data_hash")]
        public string Data_hash { get; set; }
    }
}
