// Copyright (c) 2021 Quetzal Rivera.
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
        [JsonPropertyName(PropertyNames.Url)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        ///<summary>True, if a custom certificate was provided for webhook certificate checks.</summary>
        [JsonPropertyName(PropertyNames.HasCustomCertificate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HasCustomCertificate { get; set; }
        ///<summary>Number of updates awaiting delivery.</summary>
        [JsonPropertyName(PropertyNames.PendingUpdateCount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PendingUpdateCount { get; set; }
        ///<summary>Optional. Currently used webhook IP address.</summary>
        [JsonPropertyName(PropertyNames.IpAddress)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IpAddress { get; set; }
        ///<summary>Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonPropertyName(PropertyNames.LastErrorDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint LastErrorDate { get; set; }
        ///<summary>Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonPropertyName(PropertyNames.LastErrorMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastErrorMessage { get; set; }
        ///<summary>Optional. Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery.</summary>
        [JsonPropertyName(PropertyNames.MaxConnections)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxConnections { get; set; }
        ///<summary>Optional. A list of update types the bot is subscribed to. Defaults to all update types.</summary>
        [JsonPropertyName(PropertyNames.AllowedUpdates)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> Allowed_updates { get; set; }
    }
}