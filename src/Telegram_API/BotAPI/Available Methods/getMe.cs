// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
        /// <returns>User Object.</returns>
        public static User GetMe(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<User>("getMe");
        }
        /// <summary>A simple method for testing your bot's auth token. Returns basic information about the bot in form of a User object.</summary>
        /// <returns>User Object.</returns>
        public static async Task<User> GetMeAsync(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<User>("getMe").ConfigureAwait(true);
        }
    }
}