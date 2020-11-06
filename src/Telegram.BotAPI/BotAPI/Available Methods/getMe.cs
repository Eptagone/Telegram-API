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
        /// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
        /// <param name="T">Bot Client</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>User Object.</returns>
        public static User GetMe(this BotClient T)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            return T.RPC<User>("getMe");
        }
        /// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>User Object.</returns>
        public static async Task<User> GetMeAsync(this BotClient T, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            return await T.RPCA<User>("getMe", cancellationToken).ConfigureAwait(false);
        }
    }
}