﻿namespace TelegramAPI.Getting_updates
{
    /// <summary>Getting Updates</summary>
    public static partial class Getting_updates
    {
        /// <summary>Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success. Requires no parameters.</summary>
        public static bool DeleteWebhook(this BotClient T) => T.RPC<bool>("deleteWebhook");
    }
}