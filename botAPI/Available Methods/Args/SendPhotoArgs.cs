using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendPhoto method arguments</summary>
    public class SendPhotoArgs : BaseSendArgs
    {
        ///<summary>InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "photo", Required = Required.Always)]
        public object Photo { get; set; }
        ///<summary>Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
    }
}