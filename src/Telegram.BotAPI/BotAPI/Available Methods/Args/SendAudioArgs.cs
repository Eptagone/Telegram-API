﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendAudio method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendAudioArgs : BaseSendArgsReplyMarkup, ICaption, IParseMode
    {
        ///<summary>Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName("audio")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Audio { get; set; }
        ///<summary>Audio caption, 0-1024 characters</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName("caption_entities")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] Caption_entities { get; set; }
        ///<summary>Optional. Duration of the audio in seconds.</summary>
        [JsonPropertyName("duration")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Performer.</summary>
        [JsonPropertyName("performer")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; set; }
        ///<summary>Optional. Track name.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonPropertyName("thumb")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Thumb { get; set; }
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
        internal bool UseMultipart()
        {
            if (Audio != default)
            {
                if (Audio.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }

            if (Thumb != default)
            {
                if (Thumb.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }

            if (AttachFiles != default)
            {
                return true;
            }

            return false;
        }
    }
}