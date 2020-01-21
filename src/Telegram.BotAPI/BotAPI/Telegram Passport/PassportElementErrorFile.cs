﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with a document scan. The error is considered resolved when the file with the document scan changes.</summary>
    public sealed class PassportElementErrorFile : PassportElementError
    {
        /// <summary>Error source, must be file.</summary>
        [JsonPropertyName("source")]
        public override string Source => "file";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonPropertyName("type")]
        public override string Type { get; set; }
        /// <summary>Base64-encoded file hash.</summary>
        [JsonPropertyName("file_hash")]
        public string File_hash { get; set; }
    }
}