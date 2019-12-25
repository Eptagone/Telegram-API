// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>This object represents a point on the map.</summary>
    public class Location
    {
        ///<summary>Longitude as defined by sender.</summary>
        [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude { get; set; }
    }
}