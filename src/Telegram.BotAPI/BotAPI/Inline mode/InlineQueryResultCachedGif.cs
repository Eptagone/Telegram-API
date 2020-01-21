﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to an animated GIF file stored on the Telegram servers. By default, this animated GIF file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with specified content instead of the animation.</summary>
    public sealed class InlineQueryResultCachedGif : InlineQueryResult
    {
        /// <summary>Type of the result, must be gif.</summary>
        [JsonPropertyName("type")]
        public override string Type => "gif";
        /// <summary>A valid file identifier for the GIF file..</summary>
        [JsonPropertyName("gif_file_id")]
        public string Gif_file_id { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonPropertyName("title")]
        public new string Title { get; set; }
        ///<summary>Optional. Caption of the GIF file to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the GIF animation.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}