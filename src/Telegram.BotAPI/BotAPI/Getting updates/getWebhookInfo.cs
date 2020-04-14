// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Getting_updates
{
    public static partial class GettingUpdates
    {
        /// <summary>Use this method to get current webhook status. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using getUpdates, will return an object with the url field empty.</summary>
        /// <param name="T">Bot Client</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static WebhookInfo GetWebhookInfo(this BotClient T)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<WebhookInfo>("getWebhookInfo");
        }
        /// <summary>Use this method to get current webhook status. On success, returns a <see cref="WebhookInfo"/> object. If the bot is using getUpdates, will return an object with the url field empty.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<WebhookInfo> GetWebhookInfoAsync(this BotClient T, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<WebhookInfo>("getWebhookInfo", cancellationToken).ConfigureAwait(false);
        }
    }
}