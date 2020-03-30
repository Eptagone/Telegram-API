﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to get the current list of the bot's commands. Requires no parameters. Returns Array of <see cref="BotCommand"/> on success.</summary>
        /// <param name="T">BotClient</param>
        /// <returns>Array of <see cref="BotCommand"/></returns>
        public static BotCommand[] GetMyCommands(this BotClient T)
        {
            if (T == null)
                throw new ArgumentNullException(nameof(T));
            return T.RPC<BotCommand[]>("getMyCommands");
        }
        /// <summary>Use this method to get the current list of the bot's commands. Requires no parameters. Returns Array of <see cref="BotCommand"/> on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>Array of <see cref="BotCommand"/></returns>
        public static async Task<BotCommand[]> GetMyCommandsAsync(this BotClient T, [Optional] CancellationToken cancellationToken)
        {
            if (T == null)
                throw new ArgumentNullException(nameof(T));
            return await T.RPCA<BotCommand[]>("getMyCommands", cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
