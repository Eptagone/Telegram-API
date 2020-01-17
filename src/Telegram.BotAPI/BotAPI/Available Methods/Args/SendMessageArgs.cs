// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendMessage method arguments.</summary>
    public sealed class SendMessageArgs : BaseSendArgs
    {
        ///<summary>Text of the message to be sent.</summary>
        [JsonProperty(PropertyName = "text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Disables link previews for links in this message.</summary>
        [JsonProperty(PropertyName = "disable_web_page_preview", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_web_page_preview { get; set; }
    }
}