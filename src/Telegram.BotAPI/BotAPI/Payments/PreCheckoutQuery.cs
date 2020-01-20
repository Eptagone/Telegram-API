// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains information about an incoming pre-checkout query.</summary>
    public sealed class PreCheckoutQuery
    {
        /// <summary>Unique query identifier</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonPropertyName("from")]
        public Available_Types.User From { get; set; }
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code.</summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonPropertyName("total_amount")]
        public uint Total_amount { get; set; }
        /// <summary>Bot specified invoice payload.</summary>
        [JsonPropertyName("invoice_payload")]
        public string Invoice_payload { get; set; }
        /// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
        [JsonPropertyName("shipping_option_id")]
        public string Shipping_option_id { get; set; }
        /// <summary>Optional. Order info provided by the user.</summary>
        [JsonPropertyName("order_info")]
        public OrderInfo Order_info { get; set; }
    }
}