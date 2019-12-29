// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>This object represents a file uploaded to Telegram Passport. Currently all Telegram Passport files are in JPEG format when decrypted and don't exceed 10MB.</summary>
    public class PassportFile
    {
        /// <summary>Identifier for this file</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        /// <summary>File size</summary>
        [JsonProperty(PropertyName = "file_size", Required = Required.Always)]
        public uint File_size { get; set; }
        /// <summary>Unix time when the file was uploaded</summary>
        [JsonProperty(PropertyName = "file_date", Required = Required.Always)]
        public uint File_date { get; set; }
    }
}
