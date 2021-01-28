// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>This object represents an incoming inline query. When the user sends an empty query, your bot could return some default or trending results.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQuery
    {
        ///<summary>Unique identifier for this query.</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        ///<summary>Sender.</summary>
        [JsonPropertyName(PropertyNames.From)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }
        ///<summary>Optional. Sender location, only for bots that request user location.</summary>
        [JsonPropertyName(PropertyNames.Location)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Text of the query (up to 512 characters).</summary>
        [JsonPropertyName(PropertyNames.Query)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Query { get; set; }
        ///<summary>Offset of the results to be returned, can be controlled by the bot.</summary>
        [JsonPropertyName(PropertyNames.Offset)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Offset { get; set; }
    }
}