// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents an incoming callback query from a callback button in an inline keyboard. If the button that originated the query was attached to a message sent by the bot, the field message will be present. If the button was attached to a message sent via the bot (in inline mode), the field inline_message_id will be present. Exactly one of the fields data or game_short_name will be present.</summary>
    public sealed class CallbackQuery
    {
        ///<summary>Unique identifier for this query.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        ///<summary>Sender.</summary>
        [JsonPropertyName("from")]
        public User From { get; set; }
        ///<summary>Optional. Message with the callback button that originated the query. Note that message content and message date will not be available if the message is too old.</summary>
        [JsonPropertyName("message(")]
        public Message Message { get; set; }
        ///<summary>Optional. Identifier of the message sent via the bot in inline mode, that originated the query.</summary>
        [JsonPropertyName("inline_message_id")]
        public string Inline_message_id { get; set; }
        ///<summary>Global identifier, uniquely corresponding to the chat to which the message with the callback button was sent. Useful for high scores in games.</summary>
        [JsonPropertyName("chat_instance(")]
        public string Chat_instance { get; set; }
        ///<summary>Optional. Data associated with the callback button. Be aware that a bad client can send arbitrary data in this field.</summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
        ///<summary>Optional. Short name of a Game to be returned, serves as the unique identifier for the game.</summary>
        [JsonPropertyName("game_short_name(")]
        public string Game_short_name { get; set; }
    }
}