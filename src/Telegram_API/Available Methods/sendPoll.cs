// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to send a native poll. A native poll can't be sent to a private chat. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static Available_Types.Message SendPoll(this BotClient T, SendPollArgs args) => T.RPC<Available_Types.Message>("sendPoll");
    }
}
