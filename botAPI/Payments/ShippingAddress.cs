using Newtonsoft.Json;

namespace TelegramAPI.Payments
{
    /// <summary>This object represents a shipping address.</summary>
    public class ShippingAddress
    {
        /// <summary>ISO 3166-1 alpha-2 country code</summary>
        [JsonProperty(PropertyName = "country_code", Required = Required.Always)]
        public string Country_code { get; set; }
        /// <summary>State, if applicable</summary>
        [JsonProperty(PropertyName = "state", Required = Required.Always)]
        public string State { get; set; }
        /// <summary>City</summary>
        [JsonProperty(PropertyName = "city", Required = Required.Always)]
        public string City { get; set; }
        /// <summary>First line for the address</summary>
        [JsonProperty(PropertyName = "street_line1", Required = Required.Always)]
        public string Street_line1 { get; set; }
        /// <summary>Second line for the address</summary>
        [JsonProperty(PropertyName = "street_line2", Required = Required.Always)]
        public string Street_line2 { get; set; }
        /// <summary>Address post code</summary>
        [JsonProperty(PropertyName = "post_code", Required = Required.Always)]
        public string Post_code { get; set; }
    }
}
