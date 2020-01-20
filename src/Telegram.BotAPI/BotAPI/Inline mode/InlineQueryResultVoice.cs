// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a voice recording in an .ogg container encoded with OPUS. By default, this voice recording will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the the voice message.</summary>
    public sealed class InlineQueryResultVoice : InlineQueryResult
    {
        /// <summary>Type of the result, must be voice.</summary>
        [JsonPropertyName("type")]
        public override string Type => "voice";
        ///<summary>A valid URL for the voice recording.</summary>
        [JsonPropertyName("voice_url")]
        public string Voice_url { get; set; }
        ///<summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Recording duration in seconds.</summary>
        [JsonPropertyName("voice_duration")]
        public uint Voice_duration { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the voice message.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}
