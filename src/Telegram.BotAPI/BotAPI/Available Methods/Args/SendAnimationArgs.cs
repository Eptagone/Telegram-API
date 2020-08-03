﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendAnimation method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendAnimationArgs : BaseSendArgs
    {
        ///<summary>Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</summary>
        [JsonPropertyName("animation")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Animation { get; set; }
        ///<summary>Optional. Duration of sent animation in seconds.</summary>
        [JsonPropertyName("duration")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Animation width.</summary>
        [JsonPropertyName("width")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Optional. Animation height.</summary>
        [JsonPropertyName("height")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></summary>
        [JsonPropertyName("thumb")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Thumb { get; set; }
        ///<summary>Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
        internal bool UseMultipart()
        {
            if (Animation != default)
                if (Animation.GetType() == typeof(InputFile))
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
