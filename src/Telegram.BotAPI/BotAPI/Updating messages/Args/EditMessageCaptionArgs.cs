// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    /// <summary>EditMessageCaption method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EditMessageCaptionArgs : ICaption, IParseMode
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>Required if inline_message_id is not specified. Identifier of the message to edit.</summary>
        [JsonPropertyName("message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName("inline_message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
        ///<summary>New caption of the message.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName("caption_entities")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Caption_entities { get; set; }
        ///<summary>A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard.</summary>
        [JsonPropertyName("reply_markup")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
