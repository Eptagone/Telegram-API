// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Games
{
    /// <summary>Extension methods for Games</summary>
    public static partial class GamesMethods
    {
        ///<summary>Use this method to get data for high score tables. Will return the score of the specified user and several of his neighbors in a game. On success, returns an Array of GameHighScore objects.<para>This method will currently return scores for the target user, plus two of his closest neighbors on each side. Will also return the top three users if the user and his neighbors are not among them. Please note that this behavior is subject to change.</para></summary>
        ///<param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static GameHighScore[] GetGameScore(this BotClient T, GetGameScoreArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<GameHighScore[]>("getGameHighScores", args);
        }
    }
}
