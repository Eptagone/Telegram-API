// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a sticker stored on the Telegram servers. By default, this sticker will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the sticker.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultCachedSticker : InlineQueryResult, IInlineQueryResult
    {
        /// <summary>Type of the result, must be sticker.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "sticker";
        /// <summary>A valid file identifier of the sticker.</summary>
        [JsonPropertyName("sticker_file_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Sticker_file_id { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the sticker.</summary>
        [JsonPropertyName("input_message_content")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent Input_message_content { get; set; }
    }
}
