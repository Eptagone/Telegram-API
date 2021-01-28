// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineKeyboardMarkup : ReplyMarkup
    {
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        public InlineKeyboardMarkup() { }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(params IEnumerable<InlineKeyboardButton>[] inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(params InlineKeyboardButton[][] inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(IEnumerable<IEnumerable<InlineKeyboardButton>> inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }

        ///<summary>Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</summary>
        [JsonPropertyName(PropertyNames.InlineKeyboard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<IEnumerable<InlineKeyboardButton>> InlineKeyboard { get; set; }
    }
}