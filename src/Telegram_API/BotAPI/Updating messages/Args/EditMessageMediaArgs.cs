// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Updating_messages
{
    /// <summary>EditMessageMedia method arguments.</summary>
    public sealed class EditMessageMediaArgs
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
        ///<summary>A <see cref="InputMedia"/> object for a new media content of the message.</summary>
        [JsonProperty(PropertyName = "media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Media { get; set; }
        ///<summary>A <see cref="Available_Types.InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
    }
}
