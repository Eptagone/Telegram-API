// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Getting_updates
{
    /// <summary>Contains information about the current status of a webhook.</summary>
    public sealed class WebhookInfo
    {
        ///<summary>Webhook URL, may be empty if webhook is not set up.</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
        ///<summary>True, if a custom certificate was provided for webhook certificate checks.</summary>
        [JsonPropertyName("has_custom_certificate")]
        public bool Has_custom_certificate { get; set; }
        ///<summary>Number of updates awaiting delivery.</summary>
        [JsonPropertyName("pending_update_count")]
        public int Pending_update_count { get; set; }
        ///<summary>Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonPropertyName("Last_error_date")]
        public int Last_error_date { get; set; }
        ///<summary>Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonPropertyName("last_error_message")]
        public string Last_error_message { get; set; }
        ///<summary>Optional. Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery.</summary>
        [JsonPropertyName("max_connections")]
        public int Max_connections { get; set; }
        ///<summary>Optional. A list of update types the bot is subscribed to. Defaults to all update types.</summary>
        [JsonPropertyName("allowed_updates")]
        public string[] Allowed_updates { get; set; }
    }
}