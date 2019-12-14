using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a general file (as opposed to photos, voice messages and audio files).</summary>
    public class Document
    {
        ///<summary>Unique file identifier.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Optional. Document thumbnail as defined by sender.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. Original filename as defined by sender.</summary>
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