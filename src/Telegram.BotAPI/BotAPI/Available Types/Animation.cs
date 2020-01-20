// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents an animation file (GIF or H.264/MPEG-4 AVC video without sound).</summary>
    public sealed class Animation
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
        ///<summary>Optional. Animation thumbnail as defined by sender.</summary>
        [JsonPropertyName("thumb")]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. Original animation filename as defined by sender.</summary>
        [JsonPropertyName("file_name")]
        public string File_name { get; set; }
        ///<summary>Optional. MIME type of the file as defined by sender.</summary>
        [JsonPropertyName("mime_type")]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName("file_size")]
        public uint File_size { get; set; }
    }
}