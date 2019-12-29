// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using System;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to a sticker stored on the Telegram servers. By default, this sticker will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the sticker.</summary>
    public class InlineQueryResultCachedSticker : InlineQueryResult
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "sticker";
        /// <summary>A valid file identifier of the sticker.</summary>
        [JsonProperty(PropertyName = "sticker_file_id", Required = Required.Always)]
        public string Sticker_file_id { get; set; }
        /// <summary>Title of the result.</summary>
        [Obsolete("Don't use this", true)]
        public new string Title { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the sticker</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}
