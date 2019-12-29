// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
        /// <returns>User Object.</returns>
        public static Available_Types.User GetMe(this BotClient T) => T.RPC<Available_Types.User>("getMe");
    }
}