// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Games
{
    public static partial class GamesMethods
    {
        ///<summary>Use this method to send a game. On success, the sent Message is returned.</summary>
        ///<param name="T">BotClient</param>
        ///<param name="args">Parameters</param>
        public static Message SendGame(this BotClient T, SendGameArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Message>("sendGame", args);
        }
        ///<summary>Use this method to send a game. On success, the sent Message is returned.</summary>
        ///<param name="T">BotClient</param>
        ///<param name="args">Parameters</param>
        public static async Task<Message> SendGameAsync(this BotClient T, SendGameArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<Message>("sendGame", args).ConfigureAwait(false);
        }
    }
}
