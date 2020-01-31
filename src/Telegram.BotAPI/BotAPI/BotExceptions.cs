// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;

namespace Telegram.BotAPI
{
    /// <summary>Exception generated when a request to Telegram Bot API got an error response.</summary>
    public sealed class BotRequestException : Exception
    {
        ///<summary>Error code.</summary>
        public int Error_code { get; set; }
        ///<summary>Error description.</summary>
        public string Description { get; set; }
        internal BotRequestException(int error_code, string description) : base(description)
        {
            Error_code = error_code;
            Description = description;
        }
    }
}
