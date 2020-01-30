// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendVideo method arguments.</summary>
    public sealed class SendVideoArgs : BaseSendArgs
    {
        ///<summary>Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data.</summary>
        [JsonPropertyName("video")]
        public object Video { get; set; }
        ///<summary>Optional. Duration of sent video in seconds.</summary>
        [JsonPropertyName("duration")]
        public uint Duration { get; set; }
        ///<summary>Optional. Video width.</summary>
        [JsonPropertyName("width")]
        public uint Width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("height")]
        public uint Height { get; set; }
        ///<summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonPropertyName("thumb")]
        public object Thumb { get; set; }
        ///<summary>Optional. Video caption (may also be used when resending videos by file_id), 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Pass True, if the uploaded video is suitable for streaming.</summary>
        [JsonPropertyName("supports_streaming")]
        public bool Supports_streaming { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
        internal bool UseMultipart()
        {
            if (Video != default)
                if (Video.GetType() == typeof(InputFile))
                    return true;
            if (Thumb != default)
                if (Thumb.GetType() == typeof(InputFile))
                    return true;
            if (AttachFiles != default)
                return true;
            return false;
        }
    }
}