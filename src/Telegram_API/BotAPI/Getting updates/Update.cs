// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Getting_updates
{
    /// <summary>This object represents an incoming update. 
    /// At most one of the optional parameters can be present in any given update.</summary>
    public class Update
    {
        ///<summary>The update‘s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you’re using Webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.</summary>
        [JsonProperty(PropertyName = "update_id", Required = Required.Always)]
        public uint Update_id { get; set; }
        ///<summary>Optional. New incoming message of any kind — text, photo, sticker, etc.</summary>
        [JsonProperty(PropertyName = "message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Message Message { get; set; }
        ///<summary>Optional. New version of a message that is known to the bot and was edited.</summary>
        [JsonProperty(PropertyName = "edited_message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Message Edited_message { get; set; }
        ///<summary>Optional. New incoming channel post of any kind — text, photo, sticker, etc.</summary>
        [JsonProperty(PropertyName = "channel_post", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Message Channel_post { get; set; }
        ///<summary>Optional. New version of a channel post that is known to the bot and was edited.</summary>
        [JsonProperty(PropertyName = "edited_channel_post", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Message Edited_channel_post { get; set; }
        ///<summary>Optional. New incoming inline query.</summary>
        [JsonProperty(PropertyName = "inline_query", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Inline_mode.InlineQuery Inline_query { get; set; }
        ///<summary>Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        [JsonProperty(PropertyName = "chosen_inline_result", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Inline_mode.ChosenInlineResult Chosen_inline_result { get; set; }
        ///<summary>Optional. New incoming callback query.</summary>
        [JsonProperty(PropertyName = "callback_query", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.CallbackQuery Callback_query { get; set; }
        ///<summary>Optional. New incoming shipping query. Only for invoices with flexible price.</summary>
        [JsonProperty(PropertyName = "shipping_query", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payments.ShippingQuery Shipping_query { get; set; }
        ///<summary>Optional. New incoming pre-checkout query. Contains full information about checkout.</summary>
        [JsonProperty(PropertyName = "pre_checkout_query", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payments.PreCheckoutQuery Pre_checkout_query { get; set; }
        ///<summary>Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        [JsonProperty(PropertyName = "poll", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.Poll Poll { get; set; }
    }
}