// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Payments
{
    /// <summary>SendInvoice method arguments.</summary>
    public sealed class SendInvoiceArgs
    {
        /// <summary>Unique identifier for the target private chat.</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Product name, 1-32 characters.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Product description, 1-255 characters.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</summary>
        [JsonProperty(PropertyName = "payload", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payload { get; set; }
        /// <summary>Payments provider token, obtained via Botfather.</summary>
        [JsonProperty(PropertyName = "provider_token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Provider_token { get; set; }
        /// <summary>Unique deep-linking parameter that can be used to generate this invoice when used as a start parameter.</summary>
        [JsonProperty(PropertyName = "start_parameter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Start_parameter { get; set; }
        /// <summary>Three-letter ISO 4217 currency code, see more <a href="https://core.telegram.org/bots/payments#supported-currencies">on currencies</a>.</summary>
        [JsonProperty(PropertyName = "currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</summary>
        [JsonProperty(PropertyName = "prices", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LabeledPrice Prices { get; set; }
        /// <summary>Optional. JSON-encoded data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</summary>
        [JsonProperty(PropertyName = "provider_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Provider_data { get; set; }
        /// <summary>Optional. URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</summary>
        [JsonProperty(PropertyName = "photo_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Photo_url { get; set; }
        /// <summary>Optional. Photo size.</summary>
        [JsonProperty(PropertyName = "photo_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Photo_size { get; set; }
        /// <summary>Optional. Photo width.</summary>
        [JsonProperty(PropertyName = "photo_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Photo_width { get; set; }
        /// <summary>Optional. Photo height.</summary>
        [JsonProperty(PropertyName = "photo_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Photo_height { get; set; }
        /// <summary>Optional. Pass True, if you require the user's full name to complete the order.</summary>
        [JsonProperty(PropertyName = "need_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Need_name { get; set; }
        /// <summary>Optional. Pass True, if you require the user's phone number to complete the order.</summary>
        [JsonProperty(PropertyName = "need_phone_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Need_phone_number { get; set; }
        /// <summary>Optional. Pass True, if you require the user's email address to complete the order.</summary>
        [JsonProperty(PropertyName = "need_email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Need_email { get; set; }
        /// <summary>Optional. Pass True, if you require the user's shipping address to complete the order.</summary>
        [JsonProperty(PropertyName = "need_shipping_address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Need_shipping_addressl { get; set; }
        /// <summary>Optional. Pass True, if user's phone number should be sent to provider.</summary>
        [JsonProperty(PropertyName = "send_phone_number_to_provider", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Send_phone_number_to_provider { get; set; }
        /// <summary>Optional. Pass True, if user's email address should be sent to provider.</summary>
        [JsonProperty(PropertyName = "send_email_to_provider", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Send_email_to_provider { get; set; }
        /// <summary>Optional. Pass True, if the final price depends on the shipping method.</summary>
        [JsonProperty(PropertyName = "is_flexible", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_flexible { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonProperty(PropertyName = "disable_notification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonProperty(PropertyName = "reply_to_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint reply_to_message_id { get; set; }
        /// <summary>Optional. A <see cref="Available_Types.InlineKeyboardMarkup"/> object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
