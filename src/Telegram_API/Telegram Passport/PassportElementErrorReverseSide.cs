// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the reverse side of a document. The error is considered resolved when the file with reverse side of the document changes.</summary>
    public class PassportElementErrorReverseSide : PassportElementError
    {
        /// <summary>Error source, must be reverse_side.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "reverse_side";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “driver_license”, “identity_card”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded hash of the file with the reverse side of the document.</summary>
        [JsonProperty(PropertyName = "file_hash", Required = Required.Always)]
        public string File_hash { get; set; }
    }
}
