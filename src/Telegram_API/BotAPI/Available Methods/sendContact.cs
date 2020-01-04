﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send phone contacts. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message SendContact(this BotClient T, SendContactArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.Message>("sendContact", args);
        }
    }
}