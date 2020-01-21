﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Getting_updates
{
    /// <summary>SetWebhook method arguments</summary>
    public sealed class SetWebhookArgs
    {
        ///<summary>HTTPS url to send updates to. Use an empty string to remove webhook integration.</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
        ///<summary>Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</summary>
        [JsonPropertyName("certificate")]
        [InputFile("certificate")]
        public InputFile Certificate { get; set; }
        ///<summary>Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.</summary>
        [JsonPropertyName("max_connections")]
        public uint Max_connections { get; set; }
        ///<summary>List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</para></summary>
        [JsonPropertyName("allowed_updates")]
        public string[] Allowed_updates { get; set; }
    }
}