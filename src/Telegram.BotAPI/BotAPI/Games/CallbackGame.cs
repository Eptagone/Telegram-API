// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.Games
{
    /// <summary>A placeholder, currently holds no information. Use BotFather to set up your game.</summary>
    public class CallbackGame
    {
        private readonly string Value;
        /// <summary>Create a new CallbackGame.</summary>
        /// <param name="value"></param>
        public CallbackGame(string value)
        {
            Value = value;
        }

        /// <summary>String from CallbackGame.</summary>
        /// <param name="callbackGame">Callbackgame</param>
        public static implicit operator string(CallbackGame callbackGame)
        {
            if (callbackGame == default)
                return default;
            else
                return callbackGame.Value;
        }
        /// <summary>CallbackGame from string.</summary>
        /// <param name="callbackGame">String</param>
        public static implicit operator CallbackGame(string callbackGame)
        {
            return new CallbackGame(callbackGame);
        }
    }
}
