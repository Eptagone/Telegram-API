// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound). By default, this animated MPEG-4 file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    public sealed class InlineQueryResultMpeg4Gif : InlineQueryResult
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonPropertyName("type")]
        public override string Type => "mpeg4_gif";
        ///<summary>A valid URL for the MP4 file. File size must not exceed 1MB.</summary>
        [JsonPropertyName("mpeg4_url")]
        public string Mpeg4_url { get; set; }
        /// <summary>Optional. Video width.</summary>
        [JsonPropertyName("mpeg4_width")]
        public int Mpeg4_width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("mpeg4_height")]
        public int Mpeg4_height { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("mpeg4_duration")]
        public int Mpeg4_duration { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonPropertyName("thumb_url")]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonPropertyName("title")]
        public new string Title { get; set; }
        ///<summary>Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the video animation.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}