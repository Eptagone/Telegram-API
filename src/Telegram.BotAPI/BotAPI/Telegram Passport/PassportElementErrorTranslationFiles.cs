// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the translated version of a document. The error is considered resolved when a file with the document translation change.</summary>
    public sealed class PassportElementErrorTranslationFiles : PassportElementError
    {
        /// <summary>Error source, must be translation_files.</summary>
        [JsonProperty(PropertyName = "source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => "translation_files";
        /// <summary>Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>List of base64-encoded file hashes.</summary>
        [JsonProperty(PropertyName = "file_hashes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] File_hashes { get; set; }
    }
}
