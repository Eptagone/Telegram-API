// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents the content of a location message to be sent as the result of an inline query.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputLocationMessageContent : InputMessageContent
    {
        ///<summary>Latitude of the location in degrees.</summary>
        [JsonPropertyName("latitude")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        ///<summary>Longitude of the location in degrees.</summary>
        [JsonPropertyName("longitude")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.</summary>
        [JsonPropertyName("live_period")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Live_period { get; set; }
    }
}
