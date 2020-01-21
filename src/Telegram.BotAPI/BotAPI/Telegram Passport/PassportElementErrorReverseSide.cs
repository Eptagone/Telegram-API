﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the reverse side of a document. The error is considered resolved when the file with reverse side of the document changes.</summary>
    public sealed class PassportElementErrorReverseSide : PassportElementError
    {
        /// <summary>Error source, must be reverse_side.</summary>
        [JsonPropertyName("source")]
        public override string Source => "reverse_side";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “driver_license”, “identity_card”.</summary>
        [JsonPropertyName("type")]
        public override string Type { get; set; }
        /// <summary>Base64-encoded hash of the file with the reverse side of the document.</summary>
        [JsonPropertyName("file_hash")]
        public string File_hash { get; set; }
    }
}