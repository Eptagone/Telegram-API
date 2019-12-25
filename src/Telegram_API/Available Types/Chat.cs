// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a chat.</summary>
    public class Chat
    {
        /// <summary>Unique identifier for this chat.</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public long Id { get; set; }
        /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Type { get; set; }
        /// <summary>Optional. Title, for supergroups, channels and group chats.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Optional. Username, for private chats, supergroups and channels if available.</summary>
        [JsonProperty(PropertyName = "username", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }
        /// <summary>Optional. First name of the other party in a private chat.</summary>
        [JsonProperty(PropertyName = "first_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First_name { get; set; }
        /// <summary>Optional. Last name of the other party in a private chat.</summary>
        [JsonProperty(PropertyName = "last_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_name { get; set; }
        /// <summary>Optional. Chat photo. Returned only in getChat..</summary>
        [JsonProperty(PropertyName = "photo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPhoto Photo { get; set; }
        /// <summary>Optional. Description, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Optional. Chat invite link, for supergroups and channel chats. Each administrator in a chat generates their own invite links, so the bot must first generate the link using exportChatInviteLink. Returned only in getChat.</summary>
        [JsonProperty(PropertyName = "invite_link", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Invite_link { get; set; }
        /// <summary>Optional. Pinned message, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonProperty(PropertyName = "pinned_message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Pinned_message { get; set; }
        /// <summary>Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.</summary>
        [JsonProperty(PropertyName = "permissions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. For supergroups, name of group sticker set. Returned only in getChat.</summary>
        [JsonProperty(PropertyName = "sticker_set_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Sticker_set_name { get; set; }
        /// <summary>Optional. True, if the bot can change the group sticker set. Returned only in getChat.</summary>
        [JsonProperty(PropertyName = "can_set_sticker_set", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_set_sticker_set { get; set; }
    }
}