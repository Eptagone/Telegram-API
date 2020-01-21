﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a sticker stored on the Telegram servers. By default, this sticker will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the sticker.</summary>
    public sealed class InlineQueryResultCachedSticker : InlineQueryResult
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonPropertyName("type")]
        public override string Type => "sticker";
        /// <summary>A valid file identifier of the sticker.</summary>
        [JsonPropertyName("sticker_file_id")]
        public string Sticker_file_id { get; set; }
        /// <summary>Title of the result.</summary>
        [Obsolete("Don't use this", true)]
        public new string Title { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the sticker</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}