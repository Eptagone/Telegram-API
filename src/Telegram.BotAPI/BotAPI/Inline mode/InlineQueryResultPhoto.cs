// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a link to a photo. By default, this photo will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the photo.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultPhoto : InlineQueryResultWithEntities, IInlineQueryResult, ICaption
    {
        /// <summary>Type of the result, must be photo.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "photo";
        /// <summary>A valid URL of the photo. Photo must be in jpeg format. Photo size must not exceed 5MB.</summary>
        [JsonPropertyName(PropertyNames.PhotoUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhotoUrl { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
        [JsonPropertyName(PropertyNames.ThumbUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbUrl { get; set; }
        /// <summary>Optional. Width of the photo.</summary>
        [JsonPropertyName(PropertyNames.PhotoWidth)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoWidth { get; set; }
        /// <summary>Optional. Height of the photo.</summary>
        [JsonPropertyName(PropertyNames.PhotoHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PhotoHeight { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        ///<summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the photo.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }
    }
}