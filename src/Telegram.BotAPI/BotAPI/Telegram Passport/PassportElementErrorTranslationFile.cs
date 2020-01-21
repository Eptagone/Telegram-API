﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with one of the files that constitute the translation of a document. The error is considered resolved when the file changes.</summary>
    public sealed class PassportElementErrorTranslationFile : PassportElementError
    {
        /// <summary>Error source, must be translation_file.</summary>
        [JsonPropertyName("source")]
        public override string Source => "translation_file";
        /// <summary>Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonPropertyName("type")]
        public override string Type { get; set; }
        /// <summary>Base64-encoded file hash.</summary>
        [JsonPropertyName("file_hash")]
        public string File_hash { get; set; }
    }
}