// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Games
{
    /// <summary>GetGameScore method args.</summary>
    public sealed class GetGameScoreArgs
    {
        /// <summary>Target user id.</summary>
        [JsonProperty(PropertyName = "user_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat.</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        /// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
    }
}
