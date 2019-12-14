﻿using Newtonsoft.Json;
namespace TelegramAPI.Getting_updates
{
    /// <summary>Contains information about the current status of a webhook.</summary>
    public class WebhookInfo
    {
        ///<summary>Webhook URL, may be empty if webhook is not set up.</summary>
        [JsonProperty(PropertyName = "url", Required = Required.Always)]
        public string Url { get; set; }
        ///<summary>True, if a custom certificate was provided for webhook certificate checks.</summary>
        [JsonProperty(PropertyName = "has_custom_certificate", Required = Required.Always)]
        public bool Has_custom_certificate { get; set; }
        ///<summary>Number of updates awaiting delivery.</summary>
        [JsonProperty(PropertyName = "pending_update_count", Required = Required.Always)]
        public int Pending_update_count { get; set; }
        ///<summary>Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonProperty(PropertyName = "Last_error_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Last_error_date { get; set; }
        ///<summary>Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook.</summary>
        [JsonProperty(PropertyName = "last_error_message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_error_message { get; set; }
        ///<summary>Optional. Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery.</summary>
        [JsonProperty(PropertyName = "max_connections", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Max_connections { get; set; }
        ///<summary>Optional. A list of update types the bot is subscribed to. Defaults to all update types.</summary>
        [JsonProperty(PropertyName = "allowed_updates", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Allowed_updates { get; set; }
    }
}