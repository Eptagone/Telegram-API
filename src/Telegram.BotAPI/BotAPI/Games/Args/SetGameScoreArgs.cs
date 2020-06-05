// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>SetGameScore method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SetGameScoreArgs
    {
        /// <summary>User identifier.</summary>
        [JsonPropertyName("user_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint User_id { get; set; }
        /// <summary>New score.</summary>
        [JsonPropertyName("score")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Score { get; set; }
        /// <summary>Optional. Pass True, if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters.</summary>
        [JsonPropertyName("force")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Force { get; set; }
        /// <summary>Optional. Pass True, if the game message should not be automatically edited to include the current scoreboard.</summary>
        [JsonPropertyName("disable_edit_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_edit_message { get; set; }
        /// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat.</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonPropertyName("message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        /// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName("inline_message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Inline_message_id { get; set; }
    }
}
