// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects with reply_markup property.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public interface IReplyMarkupInline
    {
        /// <summary>Optional. A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard.</summary>
        [JsonPropertyName("reply_markup")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
