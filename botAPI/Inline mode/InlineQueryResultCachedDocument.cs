using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a file stored on the Telegram servers. By default, this file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the file.</summary>
    public class InlineQueryResultCachedDocument : InlineQueryResult
    {
        /// <summary>Type of the result, must be document.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "document";
        /// <summary>A valid file identifier for the file.</summary>
        [JsonProperty(PropertyName = "document_file_id", Required = Required.Always)]
        public string Document_file_id { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", Required = Required.Always)]
        public string Description { get; set; }
        ///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
    }
}
