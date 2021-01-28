// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a result of an inline query that was chosen by the user and sent to their chat partner.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChosenInlineResult
    {
        /// <summary>The unique identifier for the result that was chosen.</summary>
        [JsonPropertyName(PropertyNames.ResultId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResultId { get; set; }
        /// <summary>The user that chose the result.</summary>
        [JsonPropertyName(PropertyNames.From)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvailableTypes.User From { get; set; }
        /// <summary>Optional. Sender location, only for bots that require user location.</summary>
        [JsonPropertyName(PropertyNames.Location)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvailableTypes.Location Location { get; set; }
        /// <summary>Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message. Will be also received in callback queries and can be used to edit the message.</summary>
        [JsonPropertyName(PropertyNames.InlineMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InlineMessageId { get; set; }
        /// <summary>The query that was used to obtain the result.</summary>
        [JsonPropertyName(PropertyNames.Query)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Query { get; set; }
    }
}