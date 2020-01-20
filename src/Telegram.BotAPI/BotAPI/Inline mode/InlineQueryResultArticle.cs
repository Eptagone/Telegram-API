// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to an article or web page.</summary>
    public sealed class InlineQueryResultArticle : InlineQueryResult
    {
        /// <summary>Type of the result, must be article.</summary>
        [JsonPropertyName("type")]
        public override string Type => "article";
        /// <summary>Optional. URL of the result.</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
        /// <summary>Optional. Pass True, if you don't want the URL to be shown in the message.</summary>
        [JsonPropertyName("hide_url")]
        public bool Hide_url { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonPropertyName("thumb_url")]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonPropertyName("thumb_width")]
        public int Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName("thumb_height")]
        public int Thumb_height { get; set; }
    }
}