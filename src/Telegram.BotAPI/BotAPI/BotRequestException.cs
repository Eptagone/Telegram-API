// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;

namespace Telegram.BotAPI
{
    /// <summary>Exception generated when a request to Telegram Bot API got an error response.</summary>
    public sealed class BotRequestException : Exception
    {
        ///<summary>Error code.</summary>
        public int ErrorCode { get; }
        ///<summary>Error description.</summary>
        public string Description { get; }
        ///<summary>Parameters.</summary>
        public Dictionary<string, object> Parameters { get; }

        internal BotRequestException(int error_code, string description, Dictionary<string, object> parameters) : base(description)
        {
            ErrorCode = error_code;
            Description = description;
            Parameters = parameters ?? new Dictionary<string, object>();
        }
    }
}
