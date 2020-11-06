// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Games
{
    public static partial class GamesMethods
    {
        ///<summary>Use this method to set the score of the specified user in a game.</summary>
        ///<param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</returns>
        public static T SetGameScore<T>(this BotClient B, SetGameScoreArgs args)
        {
            if (B == default)
            {
                throw new ArgumentNullException(nameof(B));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.Available_Types.Message or bool.");
            }
            return B.RPC<T>("setGameScore", args);
        }
        ///<summary>Use this method to set the score of the specified user in a game.</summary>
        ///<param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</returns>
        public static async Task<T> SetGameScoreAsync<T>(this BotClient B, SetGameScoreArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (B == default)
            {
                throw new ArgumentNullException(nameof(B));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.Available_Types.Message or bool.");
            }
            return await B.RPCA<T>("setGameScore", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
