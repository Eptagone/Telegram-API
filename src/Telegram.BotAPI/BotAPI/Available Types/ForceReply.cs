// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>Upon receiving a message with this object, Telegram clients will display a reply interface to the user (act as if the user has selected the bot‘s message and tapped ’Reply'). This can be extremely useful if you want to create user-friendly step-by-step interfaces without having to sacrifice privacy mode.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ForceReply : ReplyMarkup
    {
        ///<summary>Shows reply interface to the user, as if they manually selected the bot‘s message and tapped ’Reply'.</summary>
        [JsonPropertyName("force_reply")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public static bool Force_reply => true;
        ///<summary>Optional. Use this parameter if you want to force reply from specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.</summary>
        [JsonPropertyName("selective")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Selective { get; set; }
    }
}