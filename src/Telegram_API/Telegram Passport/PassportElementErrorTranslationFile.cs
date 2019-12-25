// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue with one of the files that constitute the translation of a document. The error is considered resolved when the file changes.</summary>
    public class PassportElementErrorTranslationFile : PassportElementError
    {
        /// <summary>Error source, must be translation_file.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "translation_file";
        /// <summary>Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded file hash.</summary>
        [JsonProperty(PropertyName = "file_hash", Required = Required.Always)]
        public string File_hash { get; set; }
    }
}
