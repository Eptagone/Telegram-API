using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a video file.</summary>
    public class Video
    {
        ///<summary>Unique identifier for this file.</summary>
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
        ///<summary>Optional. Video thumbnail.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. Mime type of a file as defined by sender.</summary>
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}