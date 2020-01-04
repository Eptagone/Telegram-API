// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendDocument method arguments.</summary>
    public sealed class SendDocumentArgs : BaseSendArgs
    {
        ///<summary>File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "document", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [InputFile("document")]
        public object Document { get; set; }
        ///<summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [InputFile("thumb")]
        public object Thumb { get; set; }
        ///<summary>Document caption (may also be used when resending documents by file_id), 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
    }
}