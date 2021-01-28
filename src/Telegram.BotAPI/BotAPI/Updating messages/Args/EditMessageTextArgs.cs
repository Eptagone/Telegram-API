﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
    /// <summary>EditMessage method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EditMessageTextArgs : IParseMode
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        ///<summary>Required if inline_message_id is not specified. Identifier of the message to edit.</summary>
        [JsonPropertyName("message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName("inline_message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
        ///<summary>New text of the message.</summary>
        [JsonPropertyName("text")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParseMode { get; set; }
        ///<summary>List of special entities that appear in message text, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName("entities")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Entities { get; set; }
        ///<summary>Disables link previews for links in this message</summary>
        [JsonPropertyName("disable_web_page_preview")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_web_page_preview { get; set; }
        ///<summary>A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard.</summary>
        [JsonPropertyName("reply_markup")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
