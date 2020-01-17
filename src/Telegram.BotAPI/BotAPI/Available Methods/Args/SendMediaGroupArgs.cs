// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendMediaGroud method arguments.</summary>
    public sealed class SendMediaGroupArgs
    {
        ///<summary>Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>A JSON array of <see cref="Available_Types.InputMedia"/> and <see cref="Available_Types.InputMedia"/>, describing photos and videos to be sent, must include 2–10 items.</summary>
        [JsonProperty(PropertyName = "media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InputMedia[] Media { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonProperty(PropertyName = "disable_notification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_notification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonProperty(PropertyName = "reply_to_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Reply_to_message_id { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
    }
}