// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using System;
namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to an MP3 audio file stored on the Telegram servers. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
    public sealed class InlineQueryResultCachedAudio : InlineQueryResult
    {
        /// <summary>Type of the result, must be audio.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "audio";
        /// <summary>A valid file identifier for the audio file.</summary>
        [JsonProperty(PropertyName = "audio_file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Audio_file_id { get; set; }
        /// <summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption..</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
        /// <summary>Title of the result.</summary>
        [Obsolete("Don't use this", true)]
        public new string Title { get; set; }
    }
}
