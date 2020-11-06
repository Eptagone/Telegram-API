// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send phone contacts. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendContact(this BotClient T, SendContactArgs args)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            return T.RPC<Message>("sendContact", args);
        }
        /// <summary>Use this method to send phone contacts. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendContactAsync(this BotClient T, SendContactArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await T.RPCA<Message>("sendContact", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}