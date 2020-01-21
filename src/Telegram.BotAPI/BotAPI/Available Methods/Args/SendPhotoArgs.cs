﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendPhoto method arguments</summary>
    public sealed class SendPhotoArgs : BaseSendArgs
    {
        ///<summary>InputFile or String. Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data.</summary>
        [JsonPropertyName("photo")]
        [InputFile("photo")]
        public object Photo { get; set; }
        ///<summary>Optional. Photo caption (may also be used when resending photos by file_id), 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        internal bool UseMultipart()
        {
            if (Photo != default)
                if (Photo.GetType() == typeof(InputFile))
                    return true;
            return false;
        }
    }
}