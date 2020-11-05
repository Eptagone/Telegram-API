// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to log out from the cloud Bot API server before launching the bot locally. You must log out the bot before running it locally, otherwise there is no guarantee that the bot will receive updates. After a successful call, you will not be able to log in again using the same token for 10 minutes. Returns True on success. Requires no parameters.</summary>
        /// <param name="T">Bot Client</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool LogOut(this BotClient T)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            return T.RPC<bool>("logOut");
        }
        /// <summary>Use this method to log out from the cloud Bot API server before launching the bot locally. You must log out the bot before running it locally, otherwise there is no guarantee that the bot will receive updates. After a successful call, you will not be able to log in again using the same token for 10 minutes. Returns True on success. Requires no parameters.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> LogOutAsync(this BotClient T, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("logOut", cancellationToken).ConfigureAwait(false);
        }
    }
}