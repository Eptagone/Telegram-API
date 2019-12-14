using Newtonsoft.Json;
namespace TelegramAPI.Payments
{
    /// <summary>This object contains basic information about a successful payment.</summary>
    public class SuccessfulPayment
    {
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code</summary>
        [JsonProperty(PropertyName = "currency", Required = Required.Always)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonProperty(PropertyName = "total_amount", Required = Required.Always)]
        public string Total_amount { get; set; }
        /// <summary>Bot specified invoice payload.</summary>
        [JsonProperty(PropertyName = "invoice_payload", Required = Required.Always)]
        public string Invoice_payload { get; set; }
        /// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
        [JsonProperty(PropertyName = "shipping_option_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Shipping_option_id { get; set; }
        /// <summary>Optional. Order info provided by the user.</summary>
        [JsonProperty(PropertyName = "order_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo Order_info { get; set; }
        /// <summary>Telegram payment identifier.</summary>
        [JsonProperty(PropertyName = "telegram_payment_charge_id", Required = Required.Always)]
        public string Telegram_payment_charge_id { get; set; }
        /// <summary>Provider payment identifier.</summary>
        [JsonProperty(PropertyName = "provider_payment_charge_id", Required = Required.Always)]
        public string Provider_payment_charge_id { get; set; }
    }
}