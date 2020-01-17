// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
    public sealed class InlineKeyboardMarkup : ReplyMarkup
    {
        ///<summary>Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</summary>
        [JsonProperty(PropertyName = "inline_keyboard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardButton[][] Inline_keyboard { get; set; }
    }
}