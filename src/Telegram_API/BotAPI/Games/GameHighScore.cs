// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Games
{
    /// <summary>This object represents one row of the high scores table for a game.</summary>
    public sealed class GameHighScore
    {
        /// <summary>Position in high score table for the game</summary>
        [JsonProperty(PropertyName = "position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Position { get; set; }
        /// <summary>User</summary>
        [JsonProperty(PropertyName = "user", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.User User { get; set; }
        /// <summary>Score</summary>
        [JsonProperty(PropertyName = "score", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Score { get; set; }
    }
}
