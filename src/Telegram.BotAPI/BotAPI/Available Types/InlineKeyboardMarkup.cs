// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineKeyboardMarkup : ReplyMarkup
    {
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        public InlineKeyboardMarkup() { }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(params InlineKeyboardButton[][] inlineKeyboard)
            => Inline_keyboard = inlineKeyboard;

        ///<summary>Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</summary>
        [JsonPropertyName("inline_keyboard")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardButton[][] Inline_keyboard { get; set; }
    }
}