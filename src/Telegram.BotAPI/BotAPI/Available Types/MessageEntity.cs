// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents one special entity in a text message. For example, hashtags, usernames, URLs, etc.</summary>
    public sealed class MessageEntity
    {
        /// <summary>Type of the entity. Can be “mention” (@username), “hashtag” (#hashtag), “cashtag” ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email” (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text), “italic” (italic text), “underline” (underlined text), “strikethrough” (strikethrough text), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users without usernames).</summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>Offset in UTF-16 code units to the start of the entity.</summary>
        [JsonPropertyName("offset")]
        public uint Offset { get; set; }
        /// <summary>Length of the entity in UTF-16 code units.</summary>
        [JsonPropertyName("length")]
        public uint Length { get; set; }
        /// <summary>Optional. For “text_link” only, url that will be opened after user taps on the text.</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
        /// <summary>Optional. For “text_mention” only, the mentioned user.</summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}