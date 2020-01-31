﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>RestrictChatMember method summaryeters.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RestrictChatMemberArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        /// <summary>Unique identifier of the target user.</summary>
        [JsonPropertyName("user_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        /// <summary>New user permissions.</summary>
        [JsonPropertyName("permissions")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</summary>
        [JsonPropertyName("until_date")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Until_date { get; set; }
    }
}
