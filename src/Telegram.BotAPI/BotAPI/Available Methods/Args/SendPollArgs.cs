// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendPoll method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendPollArgs : BaseSendArgs
    {
        ///<summary>Poll question, 1-255 characters.</summary>
        [JsonPropertyName("question")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Question { get; set; }
        ///<summary>List of answer options, 2-10 strings 1-100 characters each.</summary>
        [JsonPropertyName("options")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Options { get; set; }
        ///<summary>True, if the poll needs to be anonymous, defaults to True.</summary>
        [JsonPropertyName("is_anonymous")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Is_anonymous { get; set; } = true;
        ///<summary>Poll type, “quiz” or “regular”, defaults to “regular”.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        ///<summary>True, if the poll allows multiple answers, ignored for polls in quiz mode, defaults to False.</summary>
        [JsonPropertyName("allows_multiple_answers")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Allows_multiple_answers { get; set; }
        ///<summary>0-based identifier of the correct answer option, required for polls in quiz mode.</summary>
        [JsonPropertyName("correct_option_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Correct_option_id { get; set; }
        ///<summary>Pass True, if the poll needs to be immediately closed.</summary>
        [JsonPropertyName("is_closed")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_closed { get; set; }

    }
}
