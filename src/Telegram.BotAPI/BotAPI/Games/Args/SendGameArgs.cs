﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Games
{
    /// <summary>SendGame method arguments.</summary>
    public sealed class SendGameArgs
    {
        /// <summary>Unique identifier for the target chat.</summary>
        [JsonPropertyName("chat_id")]
        public long Chat_id { get; set; }
        /// <summary>Short name of the game, serves as the unique identifier for the game. Set up your games via BotFather.</summary>
        [JsonPropertyName("game_short_name")]
        public string Game_short_name { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonPropertyName("disable_notification")]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonPropertyName("reply_to_message_id")]
        public uint Reply_to_message_id { get; set; }
        /// <summary>Optional. A JSON-serialized object for an inline keyboard. If empty, one ‘Play game_title’ button will be shown. If not empty, the first button must launch the game.</summary>
        [JsonPropertyName("reply_markup")]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}