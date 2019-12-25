// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a file. By default, this file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the file. Currently, only .PDF and .ZIP files can be sent using this method.</summary>
    public class InlineQueryResultDocument : InlineQueryResult
    {
        /// <summary>Type of the result, must be document.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "document";
        ///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>A valid URL for the file.</summary>
        [JsonProperty(PropertyName = "document_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Document_url { get; set; }
        /// <summary>Mime type of the content of the file, either “application/pdf” or “application/zip”.</summary>
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the file.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
        /// <summary>Optional. URL of the thumbnail (jpeg only) for the file.</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonProperty(PropertyName = "thumb_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonProperty(PropertyName = "thumb_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_height { get; set; }
    }
}
