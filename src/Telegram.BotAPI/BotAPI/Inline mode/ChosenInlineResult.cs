// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a result of an inline query that was chosen by the user and sent to their chat partner.</summary>
    public sealed class ChosenInlineResult
    {
        /// <summary>The unique identifier for the result that was chosen.</summary>
        [JsonPropertyName("result_id")]
        public string Result_id { get; set; }
        /// <summary>The user that chose the result.</summary>
        [JsonPropertyName("from")]
        public Available_Types.User From { get; set; }
        /// <summary>Optional. Sender location, only for bots that require user location.</summary>
        [JsonPropertyName("location")]
        public Available_Types.Location Location { get; set; }
        /// <summary>Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message. Will be also received in callback queries and can be used to edit the message.</summary>
        [JsonPropertyName("inline_message_id")]
        public string Inline_message_id { get; set; }
        /// <summary>The query that was used to obtain the result.</summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}