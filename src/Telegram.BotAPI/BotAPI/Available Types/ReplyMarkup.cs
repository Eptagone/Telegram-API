// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

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
    }
}
