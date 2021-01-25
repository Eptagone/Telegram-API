// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Getting_updates
{
    /// <summary>Getting Updates</summary>
    public static partial class GettingUpdatesExtensions
    {
        /// <summary>Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success. Requires no parameters.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="drop_pending_updates">Pass True to drop all pending updates.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool DeleteWebhook(this BotClient bot, [Optional] bool drop_pending_updates)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (drop_pending_updates)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteBoolean("drop_pending_updates", drop_pending_updates);
                json.WriteEndObject();
                json.Flush(); json.Dispose();
                stream.Seek(0, SeekOrigin.Begin);
                return bot.RPC<bool>("deleteWebhook", stream);
            }
            else
            {
                return bot.RPC<bool>("deleteWebhook");
            }
        }
        /// <summary>Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success. Requires no parameters.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="drop_pending_updates">Pass True to drop all pending updates.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> DeleteWebhookAsync(this BotClient bot, [Optional] bool drop_pending_updates, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (drop_pending_updates)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteBoolean("drop_pending_updates", drop_pending_updates);
                json.WriteEndObject();
                await json.FlushAsync(cancellationToken).ConfigureAwait(false);
                await json.DisposeAsync().ConfigureAwait(false);
                stream.Seek(0, SeekOrigin.Begin);
                return await bot.RPCA<bool>("deleteWebhook", stream, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>("deleteWebhook", cancellationToken).ConfigureAwait(false);
            }
        }
    }
}