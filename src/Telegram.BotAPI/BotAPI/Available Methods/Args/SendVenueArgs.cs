// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>Send Venue.</summary>
    public sealed class SendVenueArgs : BaseSendArgs
    {
        ///<summary>Latitude of the venue.</summary>
        [JsonProperty(PropertyName = "latitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        ///<summary>Longitude of the venue.</summary>
        [JsonProperty(PropertyName = "longitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonProperty(PropertyName = "address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue.</summary>
        [JsonProperty(PropertyName = "foursquare_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”).</summary>
        [JsonProperty(PropertyName = "foursquare_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Foursquare_type { get; set; }
    }
}