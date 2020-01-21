﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a Game.</summary>
    public sealed class InlineQueryResultGame : InlineQueryResult
    {
        /// <summary>Type of the result, must be game.</summary>
        [JsonPropertyName("type")]
        public override string Type => "game";
        /// <summary>Short name of the game.</summary>
        [JsonPropertyName("game_short_name")]
        public string Game_short_name { get; set; }
        /// <summary>Title of the result.</summary>
        [Obsolete("Don't use this", true)]
        public new string Title { get; set; }
        /// <summary>Content of the message to be sent.</summary>
        [Obsolete("Don't use this", true)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}