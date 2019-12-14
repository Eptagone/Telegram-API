using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents the content of a text message to be sent as the result of an inline query.</summary>
    public class InputTextMessageContent : InputMessageContent
    {
        ///<summary>Text of the message to be sent, 1-4096 characters.</summary>
        [JsonProperty(PropertyName = "message_text", Required = Required.Always)]
        public string Message_text { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Disables link previews for links in the sent message.</summary>
        [JsonProperty(PropertyName = "disable_web_page_preview", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_web_page_preview { get; set; }
    }
}