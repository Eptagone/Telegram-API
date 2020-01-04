﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound) stored on the Telegram servers. By default, this animated MPEG-4 file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    public sealed class InlineQueryResultCachedMpeg4Gif : InlineQueryResult
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "mpeg4_gif";
        /// <summary>A valid file identifier for the MP4 file.</summary>
        [JsonProperty(PropertyName = "mpeg4_file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mpeg4_file_id { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new string Title { get; set; }
        ///<summary>Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the video animation.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}
