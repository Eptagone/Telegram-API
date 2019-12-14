using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>This object represents a file ready to be downloaded. The file can be downloaded via the link https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;. It is guaranteed that the link will be valid for at least 1 hour. When the link expires, a new one can be requested by calling getFile.</summary>
    public class File
    {
        ///<summary>Unique identifier for this file.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Optional. File size, if known.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
        ///<summary>Optional. File path. Use https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt; to get the file.</summary>
        [JsonProperty(PropertyName = "file_path", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_path { get; set; }
    }
}