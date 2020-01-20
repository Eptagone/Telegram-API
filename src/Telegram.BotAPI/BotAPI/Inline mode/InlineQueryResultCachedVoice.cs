// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a voice message stored on the Telegram servers. By default, this voice message will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the voice message.</summary>
    public sealed class InlineQueryResultCachedVoice : InlineQueryResult
    {
        /// <summary>Type of the result, must be voice</summary>
        [JsonPropertyName("type")]
        public override string Type => "voice";
        /// <summary>A valid file identifier for the voice message.</summary>
        [JsonPropertyName("voice_file_id")]
        public string Voice_file_id { get; set; }
        /// <summary>Voice message title.</summary>
        [JsonPropertyName("title")]
        public new string Title { get; set; }
        /// <summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption..</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the voice message.</summary>
        [JsonPropertyName("input_message_content")]
        public new InputMessageContent Input_message_content { get; set; }
    }
}
