// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static Available_Types.Message SendDocument(this BotClient T, SendDocumentArgs args) => T.RPC<Available_Types.Message>("sendDocument", args);
    }
}