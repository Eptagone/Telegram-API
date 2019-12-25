// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a voice note.</summary>
    public class Voice
    {
        ///<summary>Unique identifier for this file.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Duration of the audio in seconds as defined by sender.</summary>
        [JsonProperty(PropertyName = "duration", Required = Required.Always)]
        public uint Duration { get; set; }
        ///<summary>Optional. MIME type of the file as defined by sender.</summary>
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}