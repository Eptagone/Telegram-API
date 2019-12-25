// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a video message (available in Telegram apps as of v.4.0).</summary>
    public class VideoNote
    {
        ///<summary>Unique identifier for this file.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Video width and height (diameter of the video message) as defined by sender.</summary>
        [JsonProperty(PropertyName = "length", Required = Required.Always)]
        public uint Length { get; set; }
        ///<summary>Duration of the video in seconds as defined by sender.</summary>
        [JsonProperty(PropertyName = "duration", Required = Required.Always)]
        public uint Duration { get; set; }
        ///<summary>Optional. Video thumbnail.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}