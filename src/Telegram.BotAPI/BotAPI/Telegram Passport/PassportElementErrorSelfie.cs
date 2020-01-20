// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the selfie with a document. The error is considered resolved when the file with the selfie changes.</summary>
    public sealed class PassportElementErrorSelfie : PassportElementError
    {
        /// <summary>Error source, must be selfie.</summary>
        [JsonPropertyName("source")]
        public override string Source => "selfie";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”.</summary>
        [JsonPropertyName("type")]
        public override string Type { get; set; }
        /// <summary>Base64-encoded hash of the file with the selfie.</summary>
        [JsonPropertyName("file_hash")]
        public string File_hash { get; set; }
    }
}
