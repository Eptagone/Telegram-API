// Copyright (c) 2021 Quetzal Rivera.
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
        [JsonPropertyName(PropertyNames.Currency)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonPropertyName(PropertyNames.TotalAmount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TotalAmount { get; set; }
        /// <summary>Bot specified invoice payload.</summary>
        [JsonPropertyName(PropertyNames.InvoicePayload)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoicePayload { get; set; }
        /// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
        [JsonPropertyName(PropertyNames.ShippingOptionId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShippingOptionId { get; set; }
        /// <summary>Optional. Order info provided by the user.</summary>
        [JsonPropertyName(PropertyNames.OrderInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo OrderInfo { get; set; }
        /// <summary>Telegram payment identifier.</summary>
        [JsonPropertyName(PropertyNames.TelegramPaymentChargeId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TelegramPaymentChargeId { get; set; }
        /// <summary>Provider payment identifier.</summary>
        [JsonPropertyName(PropertyNames.ProviderPaymentChargeId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProviderPaymentChargeId { get; set; }
    }
}