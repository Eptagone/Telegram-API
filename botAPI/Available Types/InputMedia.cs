using Newtonsoft.Json;
namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents the content of a media message to be sent. It should be one of: <br /><br />
    /// • <see cref="InputMediaAnimation"/><br />
    /// • <see cref="InputMediaDocument"/><br />
    /// • <see cref="InputMediaAudio"/><br />
    /// • <see cref="InputMediaPhoto"/><br />
    /// • <see cref="InputMediaVideo"/></summary>
    public class InputMedia
    {
        ///<summary>Type of the result.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public virtual string Type { get; }
        ///<summary>File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Media { get; set; }
        ///<summary>Optional. Caption of the file to be sent, 0-1024 characters.</summary>
        public virtual string Caption { get; set; }
    }
}
