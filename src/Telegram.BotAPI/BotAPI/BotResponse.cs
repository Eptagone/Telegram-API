// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI
{
    /// <summary>Represents the bot's response to the request.</summary>
    /// <typeparam name="T">Result type.</typeparam>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotResponse<T>
    {
        /// <summary>True, if the request was successful, otherwise false.</summary>
        [JsonPropertyName("ok")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Ok { get; set; }
        /// <summary>Result.</summary>
        [JsonPropertyName("result")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public T Result { get; set; }
        ///<summary>Error code.</summary>
        [JsonPropertyName("error_code")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ErrorCode { get; set; }
        ///<summary>Error description.</summary>
        [JsonPropertyName("description")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        ///<summary>Parameters.</summary>
        [JsonPropertyName("parameters")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dictionary<string, object> Parameters { get; set; }
    }
}
