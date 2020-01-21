﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a file. By default, this file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the file. Currently, only .PDF and .ZIP files can be sent using this method.</summary>
    public sealed class InlineQueryResultDocument : InlineQueryResult
    {
        /// <summary>Type of the result, must be document.</summary>
        [JsonPropertyName("type")]
        public override string Type => "document";
        ///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>A valid URL for the file.</summary>
        [JsonPropertyName("document_url")]
        public string Document_url { get; set; }
        /// <summary>Mime type of the content of the file, either “application/pdf” or “application/zip”.</summary>
        [JsonPropertyName("mime_type")]
        public string Mime_type { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the file.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
        /// <summary>Optional. URL of the thumbnail (jpeg only) for the file.</summary>
        [JsonPropertyName("thumb_url")]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonPropertyName("thumb_width")]
        public uint Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName("thumb_height")]
        public uint Thumb_height { get; set; }
    }
}