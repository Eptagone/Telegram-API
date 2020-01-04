﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Updating_messages
{
    /// <summary>EditMessageCaption method arguments.</summary>
    public sealed class EditMessageCaptionArgs
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>Required if inline_message_id is not specified. Identifier of the message to edit.</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
        ///<summary>New caption of the message.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>A <see cref="Available_Types.InlineKeyboardMarkup"/> object for an inline keyboard.</summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}