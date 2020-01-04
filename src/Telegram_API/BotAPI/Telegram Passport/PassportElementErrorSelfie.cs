// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the selfie with a document. The error is considered resolved when the file with the selfie changes.</summary>
    public sealed class PassportElementErrorSelfie : PassportElementError
    {
        /// <summary>Error source, must be selfie.</summary>
        [JsonProperty(PropertyName = "source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => "selfie";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded hash of the file with the selfie.</summary>
        [JsonProperty(PropertyName = "file_hash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_hash { get; set; }
    }
}
