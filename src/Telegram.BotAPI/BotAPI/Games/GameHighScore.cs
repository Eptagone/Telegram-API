﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>This object represents one row of the high scores table for a game.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class GameHighScore
    {
        /// <summary>Position in high score table for the game</summary>
        [JsonPropertyName("position")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Position { get; set; }
        /// <summary>User</summary>
        [JsonPropertyName("user")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.User User { get; set; }
        /// <summary>Score</summary>
        [JsonPropertyName("score")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Score { get; set; }
    }
}
