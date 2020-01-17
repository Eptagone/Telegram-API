// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents a venue.</summary>
    public sealed class Venue
    {
        ///<summary>Venue location.</summary>
        [JsonProperty(PropertyName = "location", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonProperty(PropertyName = "address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue.</summary>
        [JsonProperty(PropertyName = "foursquare_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonProperty(PropertyName = "foursquare_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
    }
}