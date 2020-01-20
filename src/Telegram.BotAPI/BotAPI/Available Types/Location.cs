// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents a point on the map.</summary>
    public sealed class Location
    {
        ///<summary>Longitude as defined by sender.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
    }
}