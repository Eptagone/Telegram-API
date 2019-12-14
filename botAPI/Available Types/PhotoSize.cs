using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents one size of a photo or a file / sticker thumbnail.</summary>
    public class PhotoSize
    {
        ///<summary>Unique identifier for this file.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Photo width.</summary>
        [JsonProperty(PropertyName = "width", Required = Required.Always)]
        public uint Width { get; set; }
        ///<summary>Photo height.</summary>
        [JsonProperty(PropertyName = "height", Required = Required.Always)]
        public uint Height { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}