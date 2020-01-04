// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace TelegramAPI.Getting_updates
{
    public static partial class GettingUpdates
    {
        /// <summary>Use this method to get current webhook status. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using getUpdates, will return an object with the url field empty.</summary>
        public static WebhookInfo GetWebhookInfo(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<WebhookInfo>("getWebhookInfo");
        }
    }
}