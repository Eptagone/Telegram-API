// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains basic information about an invoice.</summary>
    public sealed class Invoice
    {
        /// <summary>Product name.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Product description.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Unique bot deep-linking parameter that can be used to generate this invoice.</summary>
        [JsonProperty(PropertyName = "start_parameter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Start_parameter { get; set; }
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code.</summary>
        [JsonProperty(PropertyName = "currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonProperty(PropertyName = "total_amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Total_amount { get; set; }
    }
}