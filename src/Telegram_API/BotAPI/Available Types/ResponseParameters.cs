// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>Contains information about why a request was unsuccessful.</summary>
    public sealed class ResponseParameters
    {
        ///<summary>Optional. The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonProperty(PropertyName = "migrate_to_chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Migrate_to_chat_id { get; set; }
        ///<summary>Optional. In case of exceeding flood control, the number of seconds left to wait before the request can be repeated.</summary>
        [JsonProperty(PropertyName = "retry_after", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Retry_after { get; set; }
    }
}