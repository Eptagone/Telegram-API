// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents one special entity in a text message. For example, hashtags, usernames, URLs, etc.</summary>
    public class MessageEntity
    {
        /// <summary>Type of the entity. Can be mention (@username), hashtag, cashtag, bot_command, url, email, phone_number, bold (bold text), italic (italic text), code (monowidth string), pre (monowidth block), text_link (for clickable text URLs), text_mention (for users without usernames).</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Type { get; set; }
        /// <summary>Offset in UTF-16 code units to the start of the entity.</summary>
        [JsonProperty(PropertyName = "offset", Required = Required.Always)]
        public uint Offset { get; set; }
        /// <summary>Length of the entity in UTF-16 code units.</summary>
        [JsonProperty(PropertyName = "length", Required = Required.Always)]
        public uint Length { get; set; }
        /// <summary>Optional. For “text_link” only, url that will be opened after user taps on the text.</summary>
        [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        /// <summary>Optional. For “text_mention” only, the mentioned user.</summary>
        [JsonProperty(PropertyName = "user", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
    }
}