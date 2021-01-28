// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a Game.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultGame : InlineQueryResult, IInlineQueryResult
    {
        /// <summary>Type of the result, must be game.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "game";
        /// <summary>Short name of the game.</summary>
        [JsonPropertyName(PropertyNames.GameShortName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GameShortName { get; set; }
    }
}
