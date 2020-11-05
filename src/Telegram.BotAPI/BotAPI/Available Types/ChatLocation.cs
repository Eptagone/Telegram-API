// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>Represents a location to which a chat is connected.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatLocation
    {
        ///<summary>The location to which the supergroup is connected. Can't be a live location.</summary>
        [JsonPropertyName("location")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Location address; 1-64 characters, as defined by the chat owner.</summary>
        [JsonPropertyName("address")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
    }
}