// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a photo. By default, this photo will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the photo.</summary>
    public sealed class InlineQueryResultPhoto : InlineQueryResult
    {
        /// <summary>Type of the result, must be photo.</summary>
        [JsonPropertyName("type")]
        public override string Type => "photo";
        /// <summary>A valid URL of the photo. Photo must be in jpeg format. Photo size must not exceed 5MB.</summary>
        [JsonPropertyName("photo_url")]
        public string Photo_url { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonPropertyName("title")]
        public new string Title { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonPropertyName("thumb_url")]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Width of the photo.</summary>
        [JsonPropertyName("photo_width")]
        public int Photo_width { get; set; }
        /// <summary>Optional. Height of the photo.</summary>
        [JsonPropertyName("photo_height")]
        public int Photo_height { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        ///<summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the photo.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}