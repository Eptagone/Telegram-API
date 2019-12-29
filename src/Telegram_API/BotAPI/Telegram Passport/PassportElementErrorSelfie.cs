// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the selfie with a document. The error is considered resolved when the file with the selfie changes.</summary>
    public class PassportElementErrorSelfie : PassportElementError
    {
        /// <summary>Error source, must be selfie.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "selfie";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded hash of the file with the selfie.</summary>
        [JsonProperty(PropertyName = "file_hash", Required = Required.Always)]
        public string File_hash { get; set; }
    }
}
