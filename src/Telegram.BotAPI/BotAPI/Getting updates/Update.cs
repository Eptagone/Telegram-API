﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Getting_updates
{
    /// <summary>This object represents an incoming update. 
    /// At most one of the optional parameters can be present in any given update.</summary>
    public sealed class Update
    {
        ///<summary>The update‘s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you’re using Webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.</summary>
        [JsonPropertyName("update_id")]
        public uint Update_id { get; set; }
        ///<summary>Optional. New incoming message of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName("message")]
        public Available_Types.Message Message { get; set; }
        ///<summary>Optional. New version of a message that is known to the bot and was edited.</summary>
        [JsonPropertyName("edited_message")]
        public Available_Types.Message Edited_message { get; set; }
        ///<summary>Optional. New incoming channel post of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName("channel_post")]
        public Available_Types.Message Channel_post { get; set; }
        ///<summary>Optional. New version of a channel post that is known to the bot and was edited.</summary>
        [JsonPropertyName("edited_channel_post")]
        public Available_Types.Message Edited_channel_post { get; set; }
        ///<summary>Optional. New incoming inline query.</summary>
        [JsonPropertyName("inline_query")]
        public Inline_mode.InlineQuery Inline_query { get; set; }
        ///<summary>Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        [JsonPropertyName("chosen_inline_result")]
        public Inline_mode.ChosenInlineResult Chosen_inline_result { get; set; }
        ///<summary>Optional. New incoming callback query.</summary>
        [JsonPropertyName("callback_query")]
        public Available_Types.CallbackQuery Callback_query { get; set; }
        ///<summary>Optional. New incoming shipping query. Only for invoices with flexible price.</summary>
        [JsonPropertyName("shipping_query")]
        public Payments.ShippingQuery Shipping_query { get; set; }
        ///<summary>Optional. New incoming pre-checkout query. Contains full information about checkout.</summary>
        [JsonPropertyName("pre_checkout_query")]
        public Payments.PreCheckoutQuery Pre_checkout_query { get; set; }
        ///<summary>Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        [JsonPropertyName("poll")]
        public Available_Types.Poll Poll { get; set; }
        /// <summary>Update type.</summary>
        [JsonIgnore]
        public UpdateType Type
        {
            get
            {
                if (Message != default)
                    return UpdateType.Message;
                if (Edited_message != default)
                    return UpdateType.Edited_message;
                if (Channel_post != default)
                    return UpdateType.Channel_post;
                if (Edited_channel_post != default)
                    return UpdateType.Edited_channel_post;
                if (Inline_query != default)
                    return UpdateType.Inline_query;
                if (Chosen_inline_result != default)
                    return UpdateType.Chosen_inline_result;
                if (Callback_query != default)
                    return UpdateType.Callback_query;
                if (Shipping_query != default)
                    return UpdateType.Shipping_query;
                if (Pre_checkout_query != default)
                    return UpdateType.Pre_checkout_query;
                if (Poll != default)
                    return UpdateType.Poll;
                return UpdateType.Unknown;
            }
        }
    }
}