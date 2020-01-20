// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
    public sealed class InlineKeyboardMarkup : ReplyMarkup
    {
        ///<summary>Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</summary>
        [JsonPropertyName("inline_keyboard")]
        public InlineKeyboardButton[][] Inline_keyboard { get; set; }
    }
}