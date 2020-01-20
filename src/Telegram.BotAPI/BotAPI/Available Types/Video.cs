// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a video file.</summary>
    public sealed class Video
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName("file_id")]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName("file_unique_id")]
        public string File_unique_id { get; set; }
        ///<summary>Video width as defined by sender.</summary>
        [JsonPropertyName("width")]
        public uint Width { get; set; }
        ///<summary>Video height as defined by sender.</summary>
        [JsonPropertyName("height")]
        public uint Height { get; set; }
        ///<summary>Duration of the video in seconds as defined by sender.</summary>
        [JsonPropertyName("duration")]
        public uint Duration { get; set; }
        ///<summary>Optional. Video thumbnail.</summary>
        [JsonPropertyName("thumb")]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. Mime type of a file as defined by sender.</summary>
        [JsonPropertyName("mime_type")]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName("file_size")]
        public uint File_size { get; set; }
    }
}