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
    public static partial class GettingUpdatesExtensions
    {
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Update[] GetUpdates(this BotClient T)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            return T.RPC<Update[]>("getUpdates");
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient T)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            return await T.RPCA<Update[]>("getUpdates").ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Update[] GetUpdates(this BotClient T, GetUpdatesArgs args)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return T.RPC<Update[]>("getUpdates", args);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient T, GetUpdatesArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await T.RPCA<Update[]>("getUpdates", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
        /// <param name="allowed_updates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Update[] GetUpdates(this BotClient T, [Optional] uint offset, [Optional] ushort limit, [Optional] uint timeout, [Optional] string[] allowed_updates)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (offset != default)
            {
                json.WriteNumber("offset", offset);
            }

            if (limit != default)
            {
                json.WriteNumber("limit", limit);
            }

            if (timeout != default)
            {
                json.WriteNumber("timeout", timeout);
            }

            if (allowed_updates != default)
            {
                json.WriteStartArray("allowed_updates");
                foreach (var value in allowed_updates)
                {
                    json.WriteStringValue(value);
                }
                json.WriteEndArray();
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Update[]>("getUpdates", stream);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
        /// <param name="allowed_updates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient T, [Optional] uint offset, [Optional] ushort limit, [Optional] uint timeout, [Optional] string[] allowed_updates, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (offset != default)
            {
                json.WriteNumber("offset", offset);
            }

            if (limit != default)
            {
                json.WriteNumber("limit", limit);
            }

            if (timeout != default)
            {
                json.WriteNumber("timeout", timeout);
            }

            if (allowed_updates != default)
            {
                json.WriteStartArray("allowed_updates");
                foreach (var value in allowed_updates)
                {
                    json.WriteStringValue(value);
                }
                json.WriteEndArray();
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Update[]>("getUpdates", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}