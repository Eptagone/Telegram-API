// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to send a group of photos or videos as an album. On success, an array of the sent Messages is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message SendMediaGroup(this BotClient T, SendMediaGroupArgs args) => T.RPC<Available_Types.Message>("sendMediaGroup", args);
    }
}