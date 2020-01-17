// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace Telegram.BotAPI.Games
{
    /// <summary>SetGameScore method arguments.</summary>
    public sealed class SetGameScoreArgs
    {
        /// <summary>User identifier.</summary>
        [JsonProperty(PropertyName = "user_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint User_id { get; set; }
        /// <summary>New score.</summary>
        [JsonProperty(PropertyName = "score", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Score { get; set; }
        /// <summary>Optional. Pass True, if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters.</summary>
        [JsonProperty(PropertyName = "force", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Force { get; set; }
        /// <summary>Optional. Pass True, if the game message should not be automatically edited to include the current scoreboard.</summary>
        [JsonProperty(PropertyName = "disable_edit_message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_edit_message { get; set; }
        /// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat.</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        /// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Inline_message_id { get; set; }
    }
}
