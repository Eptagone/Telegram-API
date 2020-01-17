// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to an animated GIF file. By default, this animated GIF file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    public sealed class InlineQueryResultGif : InlineQueryResult
    {
        /// <summary>Type of the result, must be gif.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "gif";
        ///<summary>A valid URL for the GIF file. File size must not exceed 1MB.</summary>
        [JsonProperty(PropertyName = "gif_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gif_url { get; set; }
        /// <summary>Optional. Width of the GIF.</summary>
        [JsonProperty(PropertyName = "gif_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gif_width { get; set; }
        ///<summary>Optional. Height of the GIF.</summary>
        [JsonProperty(PropertyName = "gif_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gif_height { get; set; }
        ///<summary>Optional. Duration of the GIF.</summary>
        [JsonProperty(PropertyName = "gif_duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gif_duration { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new string Title { get; set; }
        ///<summary>Optional. Caption of the GIF file to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the GIF animation.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}