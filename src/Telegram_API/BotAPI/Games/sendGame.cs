// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Games
{
    public static partial class GamesMethods
    {
        ///<summary>Use this method to send a game. On success, the sent Message is returned.</summary>
        ///<param name="T">BotClient</param>
        ///<param name="args"></param>
        public static Available_Types.Message SendGame(this BotClient T, SendGameArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Message>("sendGame", args);
        }
    }
}
