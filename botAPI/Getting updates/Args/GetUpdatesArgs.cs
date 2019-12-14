﻿using Newtonsoft.Json;
namespace TelegramAPI.Getting_updates
{
    /// <summary>GetUpdate method arguments</summary>
    public class GetUpdatesArgs
    {
        ///<summary>Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</summary>
        [JsonProperty(PropertyName = "offset", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Offset { get; set; }
        ///<summary>Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</summary>
        [JsonProperty(PropertyName = "limit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Limit { get; set; }
        ///<summary>Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</summary>
        [JsonProperty(PropertyName = "timeout", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Timeout { get; set; }
        ///<summary>List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></summary>
        [JsonProperty(PropertyName = "allowed_updates", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Allowed_updates { get; set; }
    }
}