// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.</summary>
    public sealed class PassportElementErrorDataField : PassportElementError
    {
        /// <summary>Error source, must be data.</summary>
        [JsonProperty(PropertyName = "source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => "data";
        /// <summary>The section of the user's Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>Name of the data field which has the error.</summary>
        [JsonProperty(PropertyName = "field_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Field_name { get; set; }
        /// <summary>Base64-encoded data hash.</summary>
        [JsonProperty(PropertyName = "data_hash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Data_hash { get; set; }
    }
}
