// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Getting_updates
{
    public static partial class GettingUpdates
    {
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        public static Update[] GetUpdates(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Update[]>("getUpdates");
        }

        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        public static Update[] GetUpdates(this BotClient T, GetUpdatesArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<Update[]>("getUpdates", args);
        }
    }
}