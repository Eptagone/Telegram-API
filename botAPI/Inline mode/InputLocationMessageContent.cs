using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents the content of a location message to be sent as the result of an inline query.</summary>
    public class InputLocationMessageContent : InputMessageContent
    {
        ///<summary>Latitude of the location in degrees.</summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude { get; set; }
        ///<summary>Longitude of the location in degrees.</summary>
        [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
        public float Longitude { get; set; }
        ///<summary>Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.</summary>
        [JsonProperty(PropertyName = "live_period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Live_period { get; set; }
    }
}
