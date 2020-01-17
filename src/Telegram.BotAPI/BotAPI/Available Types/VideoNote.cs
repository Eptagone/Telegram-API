// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a video message (available in Telegram apps as of v.4.0).</summary>
    public sealed class VideoNote
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_unique_id { get; set; }
        ///<summary>Video width and height (diameter of the video message) as defined by sender.</summary>
        [JsonProperty(PropertyName = "length", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Length { get; set; }
        ///<summary>Duration of the video in seconds as defined by sender.</summary>
        [JsonProperty(PropertyName = "duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Video thumbnail.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}