// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendVoice method arguments.</summary>
    public class SendVoiceArgs : BaseSendArgs
    {
        ///<summary>Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "voice", Required = Required.Always)]
        public object Voice { get; set; }
        ///<summary>Voice message caption, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", Required = Required.Always)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Duration of the voice message in seconds.</summary>
        [JsonProperty(PropertyName = "duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
    }
}