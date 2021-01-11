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
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation.</summary>
        /// <param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static T EditMessageLiveLocation<T>(this BotClient B, EditMessageLiveLocationArgs args)
        {
            if (B == default)
            {
                throw new ArgumentNullException(nameof(T));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.Available_Types.Message or bool.");
            }
            return B.RPC<T>("editMessageLiveLocation", args);
        }
        /// <summary>Use this method to edit live location messages sent by the bot or via the bot (for inline bots). A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation.</summary>
        /// <param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<T> EditMessageLiveLocationAsync<T>(this BotClient B, EditMessageLiveLocationArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (B == default)
            {
                throw new ArgumentNullException(nameof(T));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.Available_Types.Message or bool.");
            }
            return await B.RPCA<T>("editMessageLiveLocation", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}