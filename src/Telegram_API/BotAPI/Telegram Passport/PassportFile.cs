// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>This object represents a file uploaded to Telegram Passport. Currently all Telegram Passport files are in JPEG format when decrypted and don't exceed 10MB.</summary>
    public sealed class PassportFile
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_unique_id { get; set; }
        /// <summary>File size</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
        /// <summary>Unix time when the file was uploaded</summary>
        [JsonProperty(PropertyName = "file_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_date { get; set; }
    }
}
