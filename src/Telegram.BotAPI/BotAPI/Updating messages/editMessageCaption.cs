// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    public static partial class UpdatingMessages
    {
        /// <summary>Use this method to edit captions of messages.</summary>
        /// <param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static T EditMessageCaption<T>(this BotClient B, EditMessageCaptionArgs args)
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
            return B.RPC<T>("editMessageCaption", args);
        }
        /// <summary>Use this method to edit captions of messages.</summary>
        /// <param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<T> EditMessageCaptionAsync<T>(this BotClient B, EditMessageCaptionArgs args, [Optional] CancellationToken cancellationToken)
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
            return await B.RPCA<T>("editMessageCaption", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}