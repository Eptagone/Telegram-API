// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents the content of a venue message to be sent as the result of an inline query.</summary>
    public class InputVenueMessageContent : InputMessageContent
    {
        ///<summary>Latitude of the venue in degrees.</summary>
        [JsonProperty(PropertyName = "latitude", Required = Required.Always)]
        public float Latitude { get; set; }
        ///<summary>Longitude of the venue in degrees.</summary>
        [JsonProperty(PropertyName = "longitude", Required = Required.Always)]
        public float Longitude { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonProperty(PropertyName = "address", Required = Required.Always)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue, if known.</summary>
        [JsonProperty(PropertyName = "foursquare_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonProperty(PropertyName = "foursquare_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
    }
}
