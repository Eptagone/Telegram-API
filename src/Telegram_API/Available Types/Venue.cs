// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>This object represents a venue.</summary>
    public class Venue
    {
        ///<summary>Venue location.</summary>
        [JsonProperty(PropertyName = "location", Required = Required.Always)]
        public Location Location { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonProperty(PropertyName = "address", Required = Required.Always)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue.</summary>
        [JsonProperty(PropertyName = "foursquare_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonProperty(PropertyName = "foursquare_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
    }
}