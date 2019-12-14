﻿using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendLocation method arguments.</summary>
    public class SendLocationArgs : BaseSendArgs
    {
        ///<summary>Latitude of the location.</summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude { get; set; }
        ///<summary>Longitude of the location.</summary>
        [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
        public float Longitude { get; set; }
        ///<summary>Optional. Period in seconds for which the location will be updated, should be between 60 and 86400.</summary>
        [JsonProperty(PropertyName = "live_period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Live_period { get; set; }
    }
}