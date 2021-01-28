// Copyright (c) 2021 Quetzal Rivera.
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
        [JsonPropertyName(PropertyNames.UpdateId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint UpdateId { get; set; }
        ///<summary>Optional. New incoming message of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName(PropertyNames.Message)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Message { get; set; }
        ///<summary>Optional. New version of a message that is known to the bot and was edited.</summary>
        [JsonPropertyName(PropertyNames.EditedMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message EditedMessage { get; set; }
        ///<summary>Optional. New incoming channel post of any kind — text, photo, sticker, etc.</summary>
        [JsonPropertyName(PropertyNames.ChannelPost)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message ChannelPost { get; set; }
        ///<summary>Optional. New version of a channel post that is known to the bot and was edited.</summary>
        [JsonPropertyName(PropertyNames.EditedChannelPost)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message EditedChannelPost { get; set; }
        ///<summary>Optional. New incoming inline query.</summary>
        [JsonPropertyName(PropertyNames.InlineQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineQuery InlineQuery { get; set; }
        ///<summary>Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        [JsonPropertyName(PropertyNames.ChosenInlineResult)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChosenInlineResult ChosenInlineResult { get; set; }
        ///<summary>Optional. New incoming callback query.</summary>
        [JsonPropertyName(PropertyNames.CallbackQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CallbackQuery CallbackQuery { get; set; }
        ///<summary>Optional. New incoming shipping query. Only for invoices with flexible price.</summary>
        [JsonPropertyName(PropertyNames.ShippingQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingQuery ShippingQuery { get; set; }
        ///<summary>Optional. New incoming pre-checkout query. Contains full information about checkout.</summary>
        [JsonPropertyName(PropertyNames.PreCheckoutQuery)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PreCheckoutQuery PreCheckoutQuery { get; set; }
        ///<summary>Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        [JsonPropertyName(PropertyNames.Poll)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Poll Poll { get; set; }
        ///<summary>Optional. A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.</summary>
        [JsonPropertyName(PropertyNames.PollAnswer)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PollAnswer PollAnswer { get; set; }
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

                if (EditedMessage != default)
                {
                    return UpdateType.EditedMessage;
                }

                if (ChannelPost != default)
                {
                    return UpdateType.ChannelPost;
                }

                if (EditedChannelPost != default)
                {
                    return UpdateType.EditedChannelPost;
                }

                if (InlineQuery != default)
                {
                    return UpdateType.InlineQuery;
                }

                if (ChosenInlineResult != default)
                {
                    return UpdateType.ChosenInlineResult;
                }

                if (CallbackQuery != default)
                {
                    return UpdateType.CallbackQuery;
                }

                if (ShippingQuery != default)
                {
                    return UpdateType.ShippingQuery;
                }

                if (PreCheckoutQuery != default)
                {
                    return UpdateType.PreCheckoutQuery;
                }

                if (Poll != default)
                {
                    return UpdateType.Poll;
                }

                if (PollAnswer != default)
                {
                    return UpdateType.PollAnswer;
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
        EditedMessage,
        /// <summary>Channel post update</summary>
        ChannelPost,
        /// <summary>Edited channel post update</summary>
        EditedChannelPost,
        /// <summary>Inline query update</summary>
        InlineQuery,
        /// <summary>Chosen inline result update</summary>
        ChosenInlineResult,
        /// <summary>Callback query update</summary>
        CallbackQuery,
        /// <summary>Shipping query update</summary>
        ShippingQuery,
        /// <summary>Pre checkout query update</summary>
        PreCheckoutQuery,
        /// <summary>Poll update</summary>
        Poll,
        /// <summary>Poll answer update</summary>
        PollAnswer
    }
    /// <summary>Allowed updates</summary>
    public static class AllowUpdate
    {
        /// <summary>Message update: New incoming message of any kind — text, photo, sticker, etc.</summary>
        public const string Message = "message";
        /// <summary>Edited message update: New version of a message that is known to the bot and was edited.</summary>
        public const string EditedMessage = "edited_message";
        /// <summary>Channel post update: New version of a channel post that is known to the bot and was edited.</summary>
        public const string ChannelPost = "channel_post";
        /// <summary>Edited channel post update: New version of a channel post that is known to the bot and was edited.</summary>
        public const string EditedChannelPost = "edited_channel_post";
        /// <summary>Inline query update. New incoming inline query.</summary>
        public const string InlineQuery = "inline_query";
        /// <summary>Chosen inline result update: The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.</summary>
        public const string ChosenInlineResult = "chosen_inline_result";
        /// <summary>Callback query update: New incoming callback query.</summary>
        public const string CallbackQuery = "callback_query";
        /// <summary>Shipping query update: New incoming shipping query. Only for invoices with flexible price.</summary>
        public const string ShippingQuery = "shipping_query";
        /// <summary>Pre checkout query update: New incoming pre-checkout query. Contains full information about checkout.</summary>
        public const string PreCheckoutQuery = "pre_checkout_query";
        /// <summary>Poll update: New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot.</summary>
        public const string Poll = "poll";
        /// <summary>Poll answer update: A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.</summary>
        public const string PollAnswer = "poll_answer";
    }
}