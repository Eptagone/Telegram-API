﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.GettingUpdates
{
    /// <summary>This object represents an incoming update. 
    /// At most one of the optional parameters can be present in any given update.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Update
    {
        ///<summary>The update‘s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you’re using Webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.</summary>
        [JsonPropertyName("update_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Update_id { get; set; }
        ///<summary>Optional. New incoming message of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName("message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Message { get; set; }
        ///<summary>Optional. New version of a message that is known to the bot and was edited.</summary>
        [JsonPropertyName("edited_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Edited_message { get; set; }
        ///<summary>Optional. New incoming channel post of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName("channel_post")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Channel_post { get; set; }
        ///<summary>Optional. New version of a channel post that is known to the bot and was edited.</summary>
        [JsonPropertyName("edited_channel_post")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Edited_channel_post { get; set; }
        ///<summary>Optional. New incoming inline query.</summary>
        [JsonPropertyName("inline_query")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineQuery Inline_query { get; set; }
        ///<summary>Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        [JsonPropertyName("chosen_inline_result")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChosenInlineResult Chosen_inline_result { get; set; }
        ///<summary>Optional. New incoming callback query.</summary>
        [JsonPropertyName("callback_query")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CallbackQuery Callback_query { get; set; }
        ///<summary>Optional. New incoming shipping query. Only for invoices with flexible price.</summary>
        [JsonPropertyName("shipping_query")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingQuery Shipping_query { get; set; }
        ///<summary>Optional. New incoming pre-checkout query. Contains full information about checkout.</summary>
        [JsonPropertyName("pre_checkout_query")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PreCheckoutQuery Pre_checkout_query { get; set; }
        ///<summary>Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        [JsonPropertyName("poll")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Poll Poll { get; set; }
        ///<summary>Optional. A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.</summary>
        [JsonPropertyName("poll_answer")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PollAnswer Poll_answer { get; set; }
        /// <summary>Update type.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public UpdateType Type
        {
            get
            {
                if (Message != default)
                {
                    return UpdateType.Message;
                }

                if (Edited_message != default)
                {
                    return UpdateType.Edited_message;
                }

                if (Channel_post != default)
                {
                    return UpdateType.Channel_post;
                }

                if (Edited_channel_post != default)
                {
                    return UpdateType.Edited_channel_post;
                }

                if (Inline_query != default)
                {
                    return UpdateType.Inline_query;
                }

                if (Chosen_inline_result != default)
                {
                    return UpdateType.Chosen_inline_result;
                }

                if (Callback_query != default)
                {
                    return UpdateType.Callback_query;
                }

                if (Shipping_query != default)
                {
                    return UpdateType.Shipping_query;
                }

                if (Pre_checkout_query != default)
                {
                    return UpdateType.Pre_checkout_query;
                }

                if (Poll != default)
                {
                    return UpdateType.Poll;
                }

                if (Poll_answer != default)
                {
                    return UpdateType.Poll_answer;
                }

                return UpdateType.Unknown;
            }
        }
    }
    /// <summary>Available update types.</summary>
    public enum UpdateType
    {
        /// <summary>Unknown update type</summary>
        Unknown,
        /// <summary>Message update</summary>
        Message,
        /// <summary>Edited message update</summary>
        Edited_message,
        /// <summary>Channel post update</summary>
        Channel_post,
        /// <summary>Edited channel post update</summary>
        Edited_channel_post,
        /// <summary>Inline query update</summary>
        Inline_query,
        /// <summary>Chosen inline result update</summary>
        Chosen_inline_result,
        /// <summary>Callback query update</summary>
        Callback_query,
        /// <summary>Shipping query update</summary>
        Shipping_query,
        /// <summary>Pre checkout query update</summary>
        Pre_checkout_query,
        /// <summary>Poll update</summary>
        Poll,
        /// <summary>Poll answer update</summary>
        Poll_answer
    }
    /// <summary>Allowed updates</summary>
    public static class AllowUpdate
    {
        /// <summary>Message update: New incoming message of any kind — text, photo, sticker, etc.</summary>
        public const string Message = "message";
        /// <summary>Edited message update: New version of a message that is known to the bot and was edited.</summary>
        public const string Edited_message = "edited_message";
        /// <summary>Channel post update: New version of a channel post that is known to the bot and was edited.</summary>
        public const string Channel_post = "channel_post";
        /// <summary>Edited channel post update: New version of a channel post that is known to the bot and was edited.</summary>
        public const string Edited_channel_post = "edited_channel_post";
        /// <summary>Inline query update. New incoming inline query.</summary>
        public const string Inline_query = "inline_query";
        /// <summary>Chosen inline result update: The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        public const string Chosen_inline_result = "chosen_inline_result";
        /// <summary>Callback query update: New incoming callback query.</summary>
        public const string Callback_query = "callback_query";
        /// <summary>Shipping query update: New incoming shipping query. Only for invoices with flexible price.</summary>
        public const string Shipping_query = "shipping_query";
        /// <summary>Pre checkout query update: New incoming pre-checkout query. Contains full information about checkout.</summary>
        public const string Pre_checkout_query = "pre_checkout_query";
        /// <summary>Poll update: New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        public const string Poll = "poll";
        /// <summary>Poll answer update: A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.</summary>
        public const string Poll_answer = "poll_answer";
    }
}