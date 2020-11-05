// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Chat
    {
        /// <summary>Unique identifier for this chat.</summary>
        [JsonPropertyName("id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Id { get; set; }
        /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        /// <summary>Optional. Title, for supergroups, channels and group chats.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Optional. Username, for private chats, supergroups and channels if available.</summary>
        [JsonPropertyName("username")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }
        /// <summary>Optional. First name of the other party in a private chat.</summary>
        [JsonPropertyName("first_name")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First_name { get; set; }
        /// <summary>Optional. Last name of the other party in a private chat.</summary>
        [JsonPropertyName("last_name")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_name { get; set; }
        /// <summary>Optional. Chat photo. Returned only in getChat..</summary>
        [JsonPropertyName("photo")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPhoto Photo { get; set; }
        /// <summary>Optional. Bio of the other party in a private chat. Returned only in getChat.</summary>
        [JsonPropertyName("bio")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Bio { get; set; }
        /// <summary>Optional. Description, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonPropertyName("description")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Optional. Chat invite link, for supergroups and channel chats. Each administrator in a chat generates their own invite links, so the bot must first generate the link using exportChatInviteLink. Returned only in getChat.</summary>
        [JsonPropertyName("invite_link")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Invite_link { get; set; }
        /// <summary>Optional. Pinned message, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonPropertyName("pinned_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Pinned_message { get; set; }
        /// <summary>Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.</summary>
        [JsonPropertyName("permissions")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unpriviledged user. Returned only in getChat.</summary>
        [JsonPropertyName("slow_mode_delay")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Slow_mode_delay { get; set; }
        /// <summary>Optional. For supergroups, name of group sticker set. Returned only in getChat.</summary>
        [JsonPropertyName("sticker_set_name")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Sticker_set_name { get; set; }
        /// <summary>Optional. True, if the bot can change the group sticker set. Returned only in getChat.</summary>
        [JsonPropertyName("can_set_sticker_set")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_set_sticker_set { get; set; }
        /// <summary>Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats. This identifier may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier. Returned only in getChat.</summary>
        [JsonPropertyName("linked_chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Linked_chat_id { get; set; }
        /// <summary>Optional. For supergroups, the location to which the supergroup is connected. Returned only in getChat.</summary>
        [JsonPropertyName("location")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatLocation Location { get; set; }
    }
    /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”.</summary>
    public static class ChatType
    {
        /// <summary>Private chat</summary>
        public const string Private = "private";
        /// <summary>Group chat</summary>
        public const string Group = "group";
        /// <summary>Supergroup chat</summary>
        public const string Supergroup = "supergroup";
        /// <summary>Channel chat</summary>
        public const string Channel = "channel";
    }
}