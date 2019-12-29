// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Payments
{
    /// <summary>This object contains information about an incoming pre-checkout query.</summary>
    public class PreCheckoutQuery
    {
        /// <summary>Unique query identifier</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonProperty(PropertyName = "from", Required = Required.Always)]
        public Available_Types.User From { get; set; }
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code.</summary>
        [JsonProperty(PropertyName = "currency", Required = Required.Always)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonProperty(PropertyName = "total_amount", Required = Required.Always)]
        public uint Total_amount { get; set; }
        /// <summary>Bot specified invoice payload.</summary>
        [JsonProperty(PropertyName = "invoice_payload", Required = Required.Always)]
        public string Invoice_payload { get; set; }
        /// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
        [JsonProperty(PropertyName = "shipping_option_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Shipping_option_id { get; set; }
        /// <summary>Optional. Order info provided by the user.</summary>
        [JsonProperty(PropertyName = "order_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo Order_info { get; set; }
    }
}