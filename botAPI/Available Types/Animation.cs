using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents an animation file (GIF or H.264/MPEG-4 AVC video without sound).</summary>
    public class Animation
    {
        ///<summary>Unique file identifier.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Video width as defined by sender.</summary>
        [JsonProperty(PropertyName = "width", Required = Required.Always)]
        public uint Width { get; set; }
        ///<summary>Video height as defined by sender.</summary>
        [JsonProperty(PropertyName = "height", Required = Required.Always)]
        public uint Height { get; set; }
        ///<summary>Duration of the video in seconds as defined by sender.</summary>
        [JsonProperty(PropertyName = "duration", Required = Required.Always)]
        public uint Duration { get; set; }
        ///<summary>Optional. Animation thumbnail as defined by sender.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. Original animation filename as defined by sender.</summary>
        [JsonProperty(PropertyName = "file_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_name { get; set; }
        ///<summary>Optional. MIME type of the file as defined by sender.</summary>
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}