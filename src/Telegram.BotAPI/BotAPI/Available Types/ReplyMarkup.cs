// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>Reply Markup</summary>
    public abstract class ReplyMarkup
    {
        ///<summary>Returns a new ForceReply.</summary>
        public static ForceReply ForceReply()
        {
            return new ForceReply();
        }

        ///<summary>Returns a new ForceReply.</summary>
        public static ReplyKeyboardMarkup KeyboardMarkup(
            KeyboardButton[][] keyboard,
            [Optional] bool resize_keyboard,
            [Optional] bool one_time_keyboard,
            [Optional] bool selective)
        {
            return new ReplyKeyboardMarkup(keyboard, resize_keyboard, one_time_keyboard, selective); ;
        }
    }
}
