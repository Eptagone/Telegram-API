// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Getting_updates
{
    public static partial class GettingUpdates
    {
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool SetWebhook(this BotClient T, SetWebhookArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<bool>("setWebhook", args);
        }
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<bool> SetWebhookAsync(this BotClient T, SetWebhookArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return await T.RPCAF<bool>("setWebhook", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="url">HTTPS url to send updates to. Use an empty string to remove webhook integration.</param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</param>
        /// <param name="max_connections">Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.</param>
        /// <param name="allowed_updates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</para></param>
        public static bool SetWebhook(this BotClient T, string url, [Optional] InputFile certificate, [Optional] uint max_connections, [Optional] string[] allowed_updates)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (certificate == default)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteString("url", url);
                if (max_connections != default)
                    json.WriteNumber("max_connections", max_connections);
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
                return T.RPC<bool>("setWebhook", stream);
            }
            else
            {
                var args = new SetWebhookArgs { Url = url, Certificate = certificate };
                if (max_connections != default)
                    args.Max_connections = max_connections;
                if (allowed_updates != default)
                    args.Allowed_updates = allowed_updates;
                return T.RPCF<bool>("setWebhook", args);
            }
        }
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="url">HTTPS url to send updates to. Use an empty string to remove webhook integration.</param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</param>
        /// <param name="max_connections">Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.</param>
        /// <param name="allowed_updates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</para></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<bool> SetWebhookAsync(this BotClient T, string url, [Optional] InputFile certificate, [Optional] uint max_connections, [Optional] string[] allowed_updates, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (certificate == default)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteString("url", url);
                if (max_connections != default)
                    json.WriteNumber("max_connections", max_connections);
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
                await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync();
                stream.Seek(0, SeekOrigin.Begin);
                return await T.RPCA<bool>("setWebhook", stream, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                var args = new SetWebhookArgs { Url = url, Certificate = certificate };
                if (max_connections != default)
                    args.Max_connections = max_connections;
                if (allowed_updates != default)
                    args.Allowed_updates = allowed_updates;
                return await T.RPCAF<bool>("setWebhook", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}