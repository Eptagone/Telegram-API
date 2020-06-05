// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains basic information about a successful payment.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SuccessfulPayment
    {
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code</summary>
        [JsonPropertyName("currency")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonPropertyName("total_amount")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Total_amount { get; set; }
        /// <summary>Bot specified invoice payload.</summary>
        [JsonPropertyName("invoice_payload")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Invoice_payload { get; set; }
        /// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
        [JsonPropertyName("shipping_option_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Shipping_option_id { get; set; }
        /// <summary>Optional. Order info provided by the user.</summary>
        [JsonPropertyName("order_info")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo Order_info { get; set; }
        /// <summary>Telegram payment identifier.</summary>
        [JsonPropertyName("telegram_payment_charge_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Telegram_payment_charge_id { get; set; }
        /// <summary>Provider payment identifier.</summary>
        [JsonPropertyName("provider_payment_charge_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Provider_payment_charge_id { get; set; }
    }
}