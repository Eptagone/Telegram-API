// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendVoice method arguments.</summary>
    public sealed class SendVoiceArgs : BaseSendArgs
    {
        ///<summary>Audio file to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName("voice")]
        public object Voice { get; set; }
        ///<summary>Voice message caption, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Duration of the voice message in seconds.</summary>
        [JsonPropertyName("duration")]
        public uint Duration { get; set; }
        /// <summary>Attached files.</summary>
        internal bool UseMultipart()
        {
            if (Voice != default)
                if (Voice.GetType() == typeof(InputFile))
                    return true;
            return false;
        }
    }
}