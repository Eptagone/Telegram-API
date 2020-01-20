// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents the content of a location message to be sent as the result of an inline query.</summary>
    public sealed class InputLocationMessageContent : InputMessageContent
    {
        ///<summary>Latitude of the location in degrees.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        ///<summary>Longitude of the location in degrees.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        ///<summary>Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.</summary>
        [JsonPropertyName("live_period")]
        public uint Live_period { get; set; }
    }
}
