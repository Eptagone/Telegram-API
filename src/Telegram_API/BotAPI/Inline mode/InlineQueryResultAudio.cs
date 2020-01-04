// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to an mp3 audio file. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
    public sealed class InlineQueryResultAudio : InlineQueryResult
    {
        /// <summary>Type of the result, must be audio.</summary>
        [JsonProperty(PropertyName = "type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => "audio";
        ///<summary>A valid URL for the audio file.</summary>
        [JsonProperty(PropertyName = "audio_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public System.Uri Audio_url { get; set; }
        ///<summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Performer.</summary>
        [JsonProperty(PropertyName = "performer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; set; }
        /// <summary>Optional. Audio duration in seconds.</summary>
        [JsonProperty(PropertyName = "audio_duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Audio_duration { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
    }
}