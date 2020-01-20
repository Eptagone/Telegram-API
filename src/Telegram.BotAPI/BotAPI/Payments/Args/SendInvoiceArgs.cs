// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>SendInvoice method arguments.</summary>
    public sealed class SendInvoiceArgs
    {
        /// <summary>Unique identifier for the target private chat.</summary>
        [JsonPropertyName("chat_id")]
        public long Chat_id { get; set; }
        /// <summary>Product name, 1-32 characters.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>Product description, 1-255 characters.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</summary>
        [JsonPropertyName("payload")]
        public string Payload { get; set; }
        /// <summary>Payments provider token, obtained via Botfather.</summary>
        [JsonPropertyName("provider_token")]
        public string Provider_token { get; set; }
        /// <summary>Unique deep-linking parameter that can be used to generate this invoice when used as a start parameter.</summary>
        [JsonPropertyName("start_parameter")]
        public string Start_parameter { get; set; }
        /// <summary>Three-letter ISO 4217 currency code, see more <a href="https://core.telegram.org/bots/payments#supported-currencies">on currencies</a>.</summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        /// <summary>Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</summary>
        [JsonPropertyName("prices")]
        public LabeledPrice Prices { get; set; }
        /// <summary>Optional. JSON-encoded data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</summary>
        [JsonPropertyName("provider_data")]
        public string Provider_data { get; set; }
        /// <summary>Optional. URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</summary>
        [JsonPropertyName("photo_url")]
        public string Photo_url { get; set; }
        /// <summary>Optional. Photo size.</summary>
        [JsonPropertyName("photo_size")]
        public uint Photo_size { get; set; }
        /// <summary>Optional. Photo width.</summary>
        [JsonPropertyName("photo_width")]
        public uint Photo_width { get; set; }
        /// <summary>Optional. Photo height.</summary>
        [JsonPropertyName("photo_height")]
        public uint Photo_height { get; set; }
        /// <summary>Optional. Pass True, if you require the user's full name to complete the order.</summary>
        [JsonPropertyName("need_name")]
        public bool Need_name { get; set; }
        /// <summary>Optional. Pass True, if you require the user's phone number to complete the order.</summary>
        [JsonPropertyName("need_phone_number")]
        public bool Need_phone_number { get; set; }
        /// <summary>Optional. Pass True, if you require the user's email address to complete the order.</summary>
        [JsonPropertyName("need_email")]
        public bool Need_email { get; set; }
        /// <summary>Optional. Pass True, if you require the user's shipping address to complete the order.</summary>
        [JsonPropertyName("need_shipping_address")]
        public bool Need_shipping_addressl { get; set; }
        /// <summary>Optional. Pass True, if user's phone number should be sent to provider.</summary>
        [JsonPropertyName("send_phone_number_to_provider")]
        public bool Send_phone_number_to_provider { get; set; }
        /// <summary>Optional. Pass True, if user's email address should be sent to provider.</summary>
        [JsonPropertyName("send_email_to_provider")]
        public bool Send_email_to_provider { get; set; }
        /// <summary>Optional. Pass True, if the final price depends on the shipping method.</summary>
        [JsonPropertyName("is_flexible")]
        public bool Is_flexible { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonPropertyName("disable_notification")]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonPropertyName("reply_to_message_id")]
        public uint reply_to_message_id { get; set; }
        /// <summary>Optional. A <see cref="Available_Types.InlineKeyboardMarkup"/> object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</summary>
        [JsonPropertyName("reply_markup")]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
