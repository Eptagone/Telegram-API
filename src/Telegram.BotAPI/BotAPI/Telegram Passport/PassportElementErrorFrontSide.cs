// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the front side of a document. The error is considered resolved when the file with the front side of the document changes.</summary>
    public sealed class PassportElementErrorFrontSide : PassportElementError
    {
        /// <summary>Error source, must be front_side.</summary>
        [JsonPropertyName("source")]
        public override string Source => "front_side";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”.</summary>
        [JsonPropertyName("type")]
        public override string Type { get; set; }
        /// <summary>Base64-encoded hash of the file with the front side of the document.</summary>
        [JsonPropertyName("file_hash")]
        public string File_hash { get; set; }
    }
}
