// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a photo. By default, this photo will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the photo.</summary>
    public sealed class InlineQueryResultPhoto : InlineQueryResult
    {
        /// <summary>Type of the result, must be photo.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "photo";
        /// <summary>A valid URL of the photo. Photo must be in jpeg format. Photo size must not exceed 5MB.</summary>
        [JsonProperty(PropertyName = "photo_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public System.Uri Photo_url { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new string Title { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public System.Uri Thumb_url { get; set; }
        /// <summary>Optional. Width of the photo.</summary>
        [JsonProperty(PropertyName = "photo_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Photo_width { get; set; }
        /// <summary>Optional. Height of the photo.</summary>
        [JsonProperty(PropertyName = "photo_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Photo_height { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        ///<summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the photo.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}