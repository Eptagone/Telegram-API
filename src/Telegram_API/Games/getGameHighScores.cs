// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Games
{
    /// <summary>Extension methods for Games</summary>
    public static partial class Games
    {
        ///<summary>Use this method to get data for high score tables. Will return the score of the specified user and several of his neighbors in a game. On success, returns an Array of GameHighScore objects.<para>This method will currently return scores for the target user, plus two of his closest neighbors on each side. Will also return the top three users if the user and his neighbors are not among them. Please note that this behavior is subject to change.</para></summary>
        ///<param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static GameHighScore[] GetGameScore(this BotClient T, GetGameScoreArgs args) => T.RPC<GameHighScore[]>("getGameHighScores", args);
    }
    /// <summary>GetGameScore method args.</summary>
    public class GetGameScoreArgs
    {
        /// <summary>Target user id.</summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.Always)]
        public int User_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat.</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        /// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
    }
}
