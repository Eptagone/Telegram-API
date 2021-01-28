﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
    /// <summary>EditMessageMedia method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EditMessageMediaArgs : IAttachFiles
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName("inline_message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
        ///<summary>A <see cref="InputMedia"/> object for a new media content of the message.</summary>
        [JsonPropertyName("media")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Media { get; set; }
        ///<summary>A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
        [JsonPropertyName("reply_markup")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup Reply_markup { get; set; }
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public List<AttachFile> AttachFiles { get; } = new List<AttachFile>();
        internal bool UseMultipart() => AttachFiles.Any();
    }
}
