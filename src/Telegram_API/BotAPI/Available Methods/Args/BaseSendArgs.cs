// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Available_Methods
{
    /// <summary>Base object for message-sending methods arguments.</summary>
    public class BaseSendArgs
    {
        ///<summary>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "chat_id", Required = Required.Always)]
        public object Chat_id { get; set; }
        /// <summary>Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</summary>
        [JsonProperty(PropertyName = "disable_notification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonProperty(PropertyName = "reply_to_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Reply_to_message_id { get; set; }
        /// <summary>Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="Available_Types.InlineKeyboardMarkup"/> or <see cref="Available_Types.ReplyKeyboardMarkup"/> or <see cref="Available_Types.ReplyKeyboardRemove"/> or <see cref="Available_Types.ForceReply"/></summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Reply_markup { get; set; }
    }
}
