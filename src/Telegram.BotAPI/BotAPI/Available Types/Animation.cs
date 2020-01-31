﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents an animation file (GIF or H.264/MPEG-4 AVC video without sound).</summary>
    public sealed class Animation
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName("file_id")]
        [JsonProperty(PropertyName = "file_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName("file_unique_id")]
        [JsonProperty(PropertyName = "file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_unique_id { get; set; }
        ///<summary>Video width as defined by sender.</summary>
        [JsonPropertyName("width")]
        [JsonProperty(PropertyName = "width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Video height as defined by sender.</summary>
        [JsonPropertyName("height")]
        [JsonProperty(PropertyName = "height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>Duration of the video in seconds as defined by sender.</summary>
        [JsonPropertyName("duration")]
        [JsonProperty(PropertyName = "duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Animation thumbnail as defined by sender.</summary>
        [JsonPropertyName("thumb")]
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. Original animation filename as defined by sender.</summary>
        [JsonPropertyName("file_name")]
        [JsonProperty(PropertyName = "file_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_name { get; set; }
        ///<summary>Optional. MIME type of the file as defined by sender.</summary>
        [JsonPropertyName("mime_type")]
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName("file_size")]
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}