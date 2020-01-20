// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents one size of a photo or a file / sticker thumbnail.</summary>
    public sealed class PhotoSize
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName("file_id")]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName("file_unique_id")]
        public string File_unique_id { get; set; }
        ///<summary>Photo width.</summary>
        [JsonPropertyName("width")]
        public uint Width { get; set; }
        ///<summary>Photo height.</summary>
        [JsonPropertyName("height")]
        public uint Height { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName("file_size")]
        public uint File_size { get; set; }
    }
}