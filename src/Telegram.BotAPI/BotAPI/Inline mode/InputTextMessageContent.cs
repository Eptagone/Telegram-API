﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents the content of a text message to be sent as the result of an inline query.</summary>
    public sealed class InputTextMessageContent : InputMessageContent
    {
        ///<summary>Text of the message to be sent, 1-4096 characters.</summary>
        [JsonPropertyName("message_text")]
        public string Message_text { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Disables link previews for links in the sent message.</summary>
        [JsonPropertyName("disable_web_page_preview")]
        public bool Disable_web_page_preview { get; set; }
    }
}