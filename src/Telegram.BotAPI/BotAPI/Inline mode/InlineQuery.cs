// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>This object represents an incoming inline query. When the user sends an empty query, your bot could return some default or trending results.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQuery
    {
        ///<summary>Unique identifier for this query.</summary>
        [JsonPropertyName("id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        ///<summary>Sender.</summary>
        [JsonPropertyName("from")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.User From { get; set; }
        ///<summary>Optional. Sender location, only for bots that request user location.</summary>
        [JsonPropertyName("location")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Location Location { get; set; }
        ///<summary>Text of the query (up to 512 characters).</summary>
        [JsonPropertyName("query")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Query { get; set; }
        ///<summary>Offset of the results to be returned, can be controlled by the bot.</summary>
        [JsonPropertyName("offset")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Offset { get; set; }
    }
}