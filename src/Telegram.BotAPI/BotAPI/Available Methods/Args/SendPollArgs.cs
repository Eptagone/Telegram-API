// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendPoll method arguments.</summary>
    public sealed class SendPollArgs : BaseSendArgs
    {
        ///<summary>Poll question, 1-255 characters.</summary>
        [JsonPropertyName("question")]
        public string Question { get; set; }
        ///<summary>List of answer options, 2-10 strings 1-100 characters each.</summary>
        [JsonPropertyName("options")]
        public string[] Options { get; set; }
    }
}
