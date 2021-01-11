// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents the content of a service message, sent whenever a user in the chat triggers a proximity alert set by another user.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ProximityAlertTriggered
    {
        ///<summary>User that triggered the alert.</summary>
        [JsonPropertyName("traveler")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Traveler { get; set; }
        ///<summary>User that set the alert.</summary>
        [JsonPropertyName("watcher")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Watcher { get; set; }
        ///<summary>The distance between the users.</summary>
        [JsonPropertyName("distance")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Distance { get; set; }
    }
}