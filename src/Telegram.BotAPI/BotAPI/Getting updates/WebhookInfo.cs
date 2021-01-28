﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.GettingUpdates
{
    /// <summary>Contains information about the current status of a webhook.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class WebhookInfo
    {
        ///<summary>Webhook URL, may be empty if webhook is not set up.</summary>
        [JsonPropertyName("url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        ///<summary>True, if a custom certificate was provided for webhook certificate checks.</summary>
        [JsonPropertyName("has_custom_certificate")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Has_custom_certificate { get; set; }
        ///<summary>Number of updates awaiting delivery.</summary>
        [JsonPropertyName("pending_update_count")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Pending_update_count { get; set; }
        ///<summary>Optional. Currently used webhook IP address.</summary>
        [JsonPropertyName("ip_address")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Ip_address { get; set; }
        ///<summary>Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonPropertyName("Last_error_date")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Last_error_date { get; set; }
        ///<summary>Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonPropertyName("last_error_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_error_message { get; set; }
        ///<summary>Optional. Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery.</summary>
        [JsonPropertyName("max_connections")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Max_connections { get; set; }
        ///<summary>Optional. A list of update types the bot is subscribed to. Defaults to all update types.</summary>
        [JsonPropertyName("allowed_updates")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> Allowed_updates { get; set; }
    }
}