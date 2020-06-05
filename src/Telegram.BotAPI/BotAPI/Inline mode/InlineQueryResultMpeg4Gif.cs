// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound). By default, this animated MPEG-4 file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultMpeg4Gif : InlineQueryResult
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "mpeg4_gif";
        ///<summary>A valid URL for the MP4 file. File size must not exceed 1MB.</summary>
        [JsonPropertyName("mpeg4_url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mpeg4_url { get; set; }
        /// <summary>Optional. Video width.</summary>
        [JsonPropertyName("mpeg4_width")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4_width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("mpeg4_height")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4_height { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("mpeg4_duration")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4_duration { get; set; }
        /// <summary>URL of the static (JPEG or GIF) or animated (MPEG4) thumbnail for the result.</summary>
        [JsonPropertyName("thumb_url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. MIME type of the thumbnail, must be one of “image/jpeg”, “image/gif”, or “video/mp4”. Defaults to “image/jpeg”.</summary>
        [JsonPropertyName("thumb_mime_type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_mime_type { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new string Title { get; set; }
        ///<summary>Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the video animation.</summary>
        [JsonPropertyName("input_message_content")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}
