﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send point on the map. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static Message SendLocation(this BotClient T, SendLocationArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Message>("sendLocation", args);
        }
        /// <summary>Use this method to send point on the map. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendLocationAsync(this BotClient T, SendLocationArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<Message>("sendLocation", args).ConfigureAwait(true);
        }
    }
}