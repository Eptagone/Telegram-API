// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound). By default, this animated MPEG-4 file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    public class InlineQueryResultMpeg4Gif : InlineQueryResult
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "mpeg4_gif";
        ///<summary>A valid URL for the MP4 file. File size must not exceed 1MB.</summary>
        [JsonProperty(PropertyName = "mpeg4_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mpeg4_url { get; set; }
        /// <summary>Optional. Video width.</summary>
        [JsonProperty(PropertyName = "mpeg4_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4_width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonProperty(PropertyName = "mpeg4_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4_height { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonProperty(PropertyName = "mpeg4_duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4_duration { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
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