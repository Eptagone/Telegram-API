// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>This object represents one row of the high scores table for a game.</summary>
    public sealed class GameHighScore
    {
        /// <summary>Position in high score table for the game</summary>
        [JsonPropertyName("position")]
        public uint Position { get; set; }
        /// <summary>User</summary>
        [JsonPropertyName("user")]
        public Available_Types.User User { get; set; }
        /// <summary>Score</summary>
        [JsonPropertyName("score")]
        public uint Score { get; set; }
    }
}
