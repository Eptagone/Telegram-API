// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents the content of a text message to be sent as the result of an inline query.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputTextMessageContent : InputMessageContent
    {
        ///<summary>Text of the message to be sent, 1-4096 characters.</summary>
        [JsonPropertyName("message_text")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message_text { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Disables link previews for links in the sent message.</summary>
        [JsonPropertyName("disable_web_page_preview")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_web_page_preview { get; set; }
    }
}