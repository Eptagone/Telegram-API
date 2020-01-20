// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>Send Venue.</summary>
    public sealed class SendVenueArgs : BaseSendArgs
    {
        ///<summary>Latitude of the venue.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        ///<summary>Longitude of the venue.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue.</summary>
        [JsonPropertyName("foursquare_id")]
        public string Foursquare_id { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”).</summary>
        [JsonPropertyName("foursquare_type")]
        public string Foursquare_type { get; set; }
    }
}