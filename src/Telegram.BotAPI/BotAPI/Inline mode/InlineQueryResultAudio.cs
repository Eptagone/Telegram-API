// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to an mp3 audio file. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
    public sealed class InlineQueryResultAudio : InlineQueryResult
    {
        /// <summary>Type of the result, must be audio.</summary>
        [JsonPropertyName("type")]
        public override string Type => "audio";
        ///<summary>A valid URL for the audio file.</summary>
        [JsonPropertyName("audio_url")]
        public string Audio_url { get; set; }
        ///<summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Performer.</summary>
        [JsonPropertyName("performer")]
        public string Performer { get; set; }
        /// <summary>Optional. Audio duration in seconds.</summary>
        [JsonPropertyName("audio_duration")]
        public uint Audio_duration { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}