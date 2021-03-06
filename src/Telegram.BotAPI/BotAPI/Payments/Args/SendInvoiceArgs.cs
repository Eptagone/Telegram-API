// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments
{
    /// <summary>SendInvoice method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendInvoiceArgs : BaseReplySendArgs, IReplyMarkup<InlineKeyboardMarkup>
    {
        /// <summary>Unique identifier for the target private chat.</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long ChatId { get; set; }
        /// <summary>Product name, 1-32 characters.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Product description, 1-255 characters.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</summary>
        [JsonPropertyName(PropertyNames.Payload)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payload { get; set; }
        /// <summary>Payments provider token, obtained via Botfather.</summary>
        [JsonPropertyName(PropertyNames.ProviderToken)]
        public string ProviderToken { get; set; }
        /// <summary>Unique deep-linking parameter that can be used to generate this invoice when used as a start parameter.</summary>
        [JsonPropertyName(PropertyNames.StartParameter)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StartParameter { get; set; }
        /// <summary>Three-letter ISO 4217 currency code, see more <a href="https://core.telegram.org/bots/payments#supported-currencies">on currencies</a>.</summary>
        [JsonPropertyName(PropertyNames.Currency)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</summary>
        [JsonPropertyName(PropertyNames.Prices)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LabeledPrice Prices { get; set; }
        /// <summary>Optional. JSON-encoded data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</summary>
        [JsonPropertyName(PropertyNames.ProviderData)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProviderData { get; set; }
        /// <summary>Optional. URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</summary>
        [JsonPropertyName(PropertyNames.PhotoUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhotoUrl { get; set; }
        /// <summary>Optional. Photo size.</summary>
        [JsonPropertyName(PropertyNames.PhotoSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint PhotoSize { get; set; }
        /// <summary>Optional. Photo width.</summary>
        [JsonPropertyName(PropertyNames.PhotoWidth)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint PhotoWidth { get; set; }
        /// <summary>Optional. Photo height.</summary>
        [JsonPropertyName(PropertyNames.PhotoHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint PhotoHeight { get; set; }
        /// <summary>Optional. Pass True, if you require the user's full name to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedName { get; set; }
        /// <summary>Optional. Pass True, if you require the user's phone number to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedPhoneNumber)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedPhoneNumber { get; set; }
        /// <summary>Optional. Pass True, if you require the user's email address to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedEmail)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedEmail { get; set; }
        /// <summary>Optional. Pass True, if you require the user's shipping address to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedShippingAddress)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NeedShippingAddressl { get; set; }
        /// <summary>Optional. Pass True, if user's phone number should be sent to provider.</summary>
        [JsonPropertyName(PropertyNames.SendPhoneNumberToProvider)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SendPhoneNumberToProvider { get; set; }
        /// <summary>Optional. Pass True, if user's email address should be sent to provider.</summary>
        [JsonPropertyName(PropertyNames.SendEmailToProvider)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SendEmailToProvider { get; set; }
        /// <summary>Optional. Pass True, if the final price depends on the shipping method.</summary>
        [JsonPropertyName(PropertyNames.IsFlexible)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsFlexible { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonPropertyName(PropertyNames.DisableNotification)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableNotification { get; set; }
        /// <summary>Optional. A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}
