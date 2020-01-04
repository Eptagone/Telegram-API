// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
        /// <returns>User Object.</returns>
        public static Available_Types.User GetMe(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Available_Types.User>("getMe");
        }
    }
}