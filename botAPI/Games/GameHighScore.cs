using Newtonsoft.Json;

namespace TelegramAPI.Games
{
    /// <summary>This object represents one row of the high scores table for a game.</summary>
    public class GameHighScore
    {
        /// <summary>Position in high score table for the game</summary>
        [JsonProperty(PropertyName = "position", Required = Required.Always)]
        public uint Position { get; set; }
        /// <summary>User</summary>
        [JsonProperty(PropertyName = "user", Required = Required.Always)]
        public Available_Types.User User { get; set; }
        /// <summary>Score</summary>
        [JsonProperty(PropertyName = "score", Required = Required.Always)]
        public uint Score { get; set; }
    }
}
