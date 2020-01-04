// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Getting_updates
{
    /// <summary>Getting Updates</summary>
    public static partial class GettingUpdates
    {
        /// <summary>Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success. Requires no parameters.</summary>
        public static bool DeleteWebhook(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("deleteWebhook");
        }
    }
}