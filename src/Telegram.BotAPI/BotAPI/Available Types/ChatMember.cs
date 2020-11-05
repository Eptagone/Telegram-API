// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object contains information about one member of a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMember
    {
        ///<summary>Information about the user.</summary>
        [JsonPropertyName("user")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        ///<summary>The member's status in the chat. Can be “creator”, “administrator”, “member”, “restricted”, “left” or “kicked”.</summary>
        [JsonPropertyName("status")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        ///<summary>Optional. Owner and administrators only. Custom title for this user.</summary>
        [JsonPropertyName("custom_title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Custom_title { get; set; }
        ///<summary>Optional. Owner and administrators only. True, if the user's presence in the chat is hidden.</summary>
        [JsonPropertyName("is_anonymous")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_anonymous { get; set; }
        ///<summary>Optional. Administrators only. True, if the bot is allowed to edit administrator privileges of that user.</summary>
        [JsonPropertyName("can_be_edited")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_be_edited { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can post in the channel, channels only.</summary>
        [JsonPropertyName("can_post_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_post_messages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can edit messages of other users and can pin messages, channels only.</summary>
        [JsonPropertyName("can_edit_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_edit_messages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can delete messages of other users.</summary>
        [JsonPropertyName("can_delete_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_delete_messages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can restrict, ban or unban chat members.</summary>
        [JsonPropertyName("can_restrict_members")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_restrict_members { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user).</summary>
        [JsonPropertyName("can_promote_members")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_promote_members { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can change the chat title, photo and other settings.</summary>
        [JsonPropertyName("can_change_info")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_change_info { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can invite new users to the chat.</summary>
        [JsonPropertyName("can_invite_users")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_invite_users { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can pin messages, supergroups only.</summary>
        [JsonPropertyName("can_pin_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_pin_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is a member of the chat at the moment of the request.</summary>
        [JsonPropertyName("is_member")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_member { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send text messages, contacts, locations and venues.</summary>
        [JsonPropertyName("can_send_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send audios, documents, photos, videos, video notes and voice notes, implies can_send_messages.</summary>
        [JsonPropertyName("can_send_media_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_media_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is allowed to send polls.</summary>
        [JsonPropertyName("can_send_polls")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_polls { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send animations, games, stickers and use inline bots, implies can_send_media_messages.</summary>
        [JsonPropertyName("can_send_other_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_other_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if user may add web page previews to his messages, implies can_send_media_messages.</summary>
        [JsonPropertyName("can_add_web_page_previews")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_add_web_page_previews { get; set; }
        ///<summary>Optional. Restricted and kicked only. Date when restrictions will be lifted for this user, unix time.</summary>
        [JsonPropertyName("until_date")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Until_date { get; set; }
    }
}