// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;

namespace Telegram.BotAPI.Getting_updates
{
    public static partial class GettingUpdates
    {
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        public static Update[] GetUpdates(this BotClient T, GetUpdatesArgs args = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if(args == default)
                return T.RPC<Update[]>("getUpdates");
            else
                return T.RPC<Update[]>("getUpdates", args);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient T, GetUpdatesArgs args = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if(args == default)
                return await T.RPCA<Update[]>("getUpdates").ConfigureAwait(true);
            else
                return await T.RPCA<Update[]>("getUpdates", args).ConfigureAwait(true);
        }
    }
}