// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>RestrictChatMember method summaryeters.</summary>
    public class RestrictChatMemberArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName("chat_id")]
        public object Chat_id { get; set; }
        /// <summary>Unique identifier of the target user.</summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; }
        /// <summary>New user permissions.</summary>
        [JsonPropertyName("permissions")]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</summary>
        [JsonPropertyName("until_date")]
        public uint Until_date { get; set; }
    }
}
