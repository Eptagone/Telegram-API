// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a page containing an embedded video player or a video file. By default, this video file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the video.</summary>
    public sealed class InlineQueryResultVideo : InlineQueryResult
    {
        /// <summary>Type of the result, must be video.</summary>
        [JsonPropertyName("type")]
        public override string Type => "video";
        ///<summary>A valid URL for the embedded video player or video file.</summary>
        [JsonPropertyName("video_url")]
        public string Video_url { get; set; }
        /// <summary>Mime type of the content of video url, “text/html” or “video/mp4”.</summary>
        [JsonPropertyName("mime_type")]
        public string Mime_type { get; set; }
        ///<summary>URL of the thumbnail (jpeg only) for the video.</summary>
        [JsonPropertyName("thumb_url")]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Video width.</summary>
        [JsonPropertyName("video_width")]
        public uint Video_width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("video_height")]
        public uint Video_height { get; set; }
        ///<summary>Optional. Video duration in seconds.</summary>
        [JsonPropertyName("video_duration")]
        public uint Video_duration { get; set; }
        ///<summary>Optional. Short description of the result.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the video. This field is required if InlineQueryResultVideo is used to send an HTML-page as a result (e.g., a YouTube video).</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}