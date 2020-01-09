// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send a group of photos or videos as an album. On success, an array of the sent Messages is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message array.</returns>
        public static Message[] SendMediaGroup(this BotClient T, SendMediaGroupArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<Message[]>("sendMediaGroup", args);
        }
        /// <summary>Use this method to send a group of photos or videos as an album. On success, an array of the sent Messages is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message array.</returns>
        public static async Task<Message[]> SendMediaGroupAsync(this BotClient T, SendMediaGroupArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return await T.RPCAF<Message[]>("sendMediaGroup", args).ConfigureAwait(true);
        }
    }
}