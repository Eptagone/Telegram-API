// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with a list of scans. The error is considered resolved when the list of files containing the scans changes.</summary>
    public sealed class PassportElementErrorFiles : PassportElementError
    {
        /// <summary>Error source, must be files.</summary>
        [JsonProperty(PropertyName = "source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => "files";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>List of base64-encoded file hashes.</summary>
        [JsonProperty(PropertyName = "file_hashes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] File_hashes { get; set; }
    }
}
