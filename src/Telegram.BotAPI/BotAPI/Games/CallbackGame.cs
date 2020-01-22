// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>A placeholder, currently holds no information. Use BotFather to set up your game.</summary>
    public class CallbackGame
    {
        /// <summary>Create a new CallbackGame.</summary>
        /// <param name="game_short_name">Game short name</param>
        public CallbackGame(string game_short_name)
        {
            Game_short_name = game_short_name;
        }

        /// <summary>Game short name</summary>
        [JsonPropertyName("game_short_name")]
        public string Game_short_name { get; set; }
    }
}
