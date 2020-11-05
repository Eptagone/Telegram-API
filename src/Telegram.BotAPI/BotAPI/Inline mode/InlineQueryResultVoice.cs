// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Inline_mode
{
    /// <summary>Represents a link to a voice recording in an .ogg container encoded with OPUS. By default, this voice recording will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the the voice message.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultVoice : InlineQueryResultWithEntities, IInlineQueryResult, ICaption
    {
        /// <summary>Type of the result, must be voice.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "voice";
        ///<summary>A valid URL for the voice recording.</summary>
        [JsonPropertyName("voice_url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Voice_url { get; set; }
        ///<summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Recording duration in seconds.</summary>
        [JsonPropertyName("voice_duration")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Voice_duration { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the voice message.</summary>
        [JsonPropertyName("input_message_content")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent Input_message_content { get; set; }
    }
}
