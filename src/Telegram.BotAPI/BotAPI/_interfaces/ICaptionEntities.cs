// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects that includes the caption and caption_entities properties.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public interface ICaption
    {
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName("caption_entities")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Caption_entities { get; set; }
    }
}
