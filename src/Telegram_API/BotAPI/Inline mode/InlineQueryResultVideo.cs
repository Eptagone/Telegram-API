// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a page containing an embedded video player or a video file. By default, this video file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the video.</summary>
    public sealed class InlineQueryResultVideo : InlineQueryResult
    {
        /// <summary>Type of the result, must be video.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "video";
        ///<summary>A valid URL for the embedded video player or video file.</summary>
        [JsonProperty(PropertyName = "video_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public System.Uri Video_url { get; set; }
        /// <summary>Mime type of the content of video url, “text/html” or “video/mp4”.</summary>
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        ///<summary>URL of the thumbnail (jpeg only) for the video.</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public System.Uri Thumb_url { get; set; }
        /// <summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Video width.</summary>
        [JsonProperty(PropertyName = "video_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Video_width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonProperty(PropertyName = "video_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Video_height { get; set; }
        ///<summary>Optional. Video duration in seconds.</summary>
        [JsonProperty(PropertyName = "video_duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Video_duration { get; set; }
        ///<summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the video. This field is required if InlineQueryResultVideo is used to send an HTML-page as a result (e.g., a YouTube video).</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}