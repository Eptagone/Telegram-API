// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    /// <summary>StopPoll method parameters.</summary>
    public class StopPollArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("chat_id")]
        public object Chat_id { get; set; }
        /// <summary>Identifier of the original message with the poll.</summary>
        [JsonPropertyName("message_id")]
        public uint Message_id { get; set; }
        /// <summary>Optional. A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</summary>
        [JsonPropertyName("reply_markup")]
        public InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
