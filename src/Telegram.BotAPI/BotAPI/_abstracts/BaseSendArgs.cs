﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI
{
    /// <summary>Base object for message-sending methods arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseSendArgs : BaseReplySendArgs
    {
        ///<summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        /// <summary>Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</summary>
        [JsonPropertyName("disable_notification")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_notification { get; set; }
    }
}
