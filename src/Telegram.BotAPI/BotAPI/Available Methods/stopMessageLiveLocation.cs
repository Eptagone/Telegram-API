// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
        public static T StopMessageLiveLocation<T>(this BotClient bot, StopMessageLiveLocationArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.Available_Types.Message or bool.");
            }
            return bot.RPC<T>("stopMessageLiveLocation", args);
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
        public static async Task<T> StopMessageLiveLocationAsync<T>(this BotClient bot, StopMessageLiveLocationArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.Available_Types.Message or bool.");
            }
            return await bot.RPCA<T>("stopMessageLiveLocation", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
