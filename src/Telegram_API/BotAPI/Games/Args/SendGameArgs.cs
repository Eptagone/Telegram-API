﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Games
{
    /// <summary>SendGame method arguments.</summary>
    public sealed class SendGameArgs
    {
        /// <summary>Unique identifier for the target chat.</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Short name of the game, serves as the unique identifier for the game. Set up your games via BotFather.</summary>
        [JsonProperty(PropertyName = "game_short_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Game_short_name { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonProperty(PropertyName = "disable_notification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonProperty(PropertyName = "reply_to_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Reply_to_message_id { get; set; }
        /// <summary>Optional. A JSON-serialized object for an inline keyboard. If empty, one ‘Play game_title’ button will be shown. If not empty, the first button must launch the game.</summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
