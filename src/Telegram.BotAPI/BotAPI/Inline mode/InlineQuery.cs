// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>This object represents an incoming inline query. When the user sends an empty query, your bot could return some default or trending results.</summary>
    public sealed class InlineQuery
    {
        ///<summary>Unique identifier for this query.</summary>
        [JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        ///<summary>Sender.</summary>
        [JsonProperty(PropertyName = "from", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.User From { get; set; }
        ///<summary>Optional. Sender location, only for bots that request user location.</summary>
        [JsonProperty(PropertyName = "location", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Location Location { get; set; }
        ///<summary>Text of the query (up to 512 characters).</summary>
        [JsonProperty(PropertyName = "query", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Query { get; set; }
        ///<summary>Offset of the results to be returned, can be controlled by the bot.</summary>
        [JsonProperty(PropertyName = "offset", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Offset { get; set; }
    }
}