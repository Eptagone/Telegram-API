// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a chat.</summary>
    public sealed class Chat
    {
        /// <summary>Unique identifier for this chat.</summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
        /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”.</summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>Optional. Title, for supergroups, channels and group chats.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>Optional. Username, for private chats, supergroups and channels if available.</summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
        /// <summary>Optional. First name of the other party in a private chat.</summary>
        [JsonPropertyName("first_name")]
        public string First_name { get; set; }
        /// <summary>Optional. Last name of the other party in a private chat.</summary>
        [JsonPropertyName("last_name")]
        public string Last_name { get; set; }
        /// <summary>Optional. Chat photo. Returned only in getChat..</summary>
        [JsonPropertyName("photo")]
        public ChatPhoto Photo { get; set; }
        /// <summary>Optional. Description, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>Optional. Chat invite link, for supergroups and channel chats. Each administrator in a chat generates their own invite links, so the bot must first generate the link using exportChatInviteLink. Returned only in getChat.</summary>
        [JsonPropertyName("invite_link")]
        public string Invite_link { get; set; }
        /// <summary>Optional. Pinned message, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonPropertyName("pinned_message")]
        public Message Pinned_message { get; set; }
        /// <summary>Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.</summary>
        [JsonPropertyName("permissions")]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unpriviledged user. Returned only in getChat.</summary>
        [JsonPropertyName("slow_mode_delay")]
        public uint Slow_mode_delay { get; set; }
        /// <summary>Optional. For supergroups, name of group sticker set. Returned only in getChat.</summary>
        [JsonPropertyName("sticker_set_name")]
        public string Sticker_set_name { get; set; }
        /// <summary>Optional. True, if the bot can change the group sticker set. Returned only in getChat.</summary>
        [JsonPropertyName("can_set_sticker_set")]
        public bool Can_set_sticker_set { get; set; }
    }
}