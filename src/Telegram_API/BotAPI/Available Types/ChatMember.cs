// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>This object contains information about one member of a chat.</summary>
    public class ChatMember
    {
        ///<summary>Information about the user.</summary>
        [JsonProperty(PropertyName = "user", Required = Required.Always)]
        public User User { get; set; }
        ///<summary>The member's status in the chat. Can be “creator”, “administrator”, “member”, “restricted”, “left” or “kicked”.</summary>
        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        public string Status { get; set; }
        ///<summary>Optional. Restricted and kicked only. Date when restrictions will be lifted for this user, unix time.</summary>
        [JsonProperty(PropertyName = "until_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Until_date { get; set; }
        ///<summary>Optional. Administrators only. True, if the bot is allowed to edit administrator privileges of that user.</summary>
        [JsonProperty(PropertyName = "can_be_edited", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_be_edited { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can post in the channel, channels only.</summary>
        [JsonProperty(PropertyName = "can_post_message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_post_messages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can edit messages of other users and can pin messages, channels only.</summary>
        [JsonProperty(PropertyName = "can_edit_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_edit_messages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can delete messages of other users.</summary>
        [JsonProperty(PropertyName = "can_delete_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_delete_messages { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can restrict, ban or unban chat members.</summary>
        [JsonProperty(PropertyName = "can_restrict_members", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_restrict_members { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by the user).</summary>
        [JsonProperty(PropertyName = "can_promote_members", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_promote_members { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can change the chat title, photo and other settings.</summary>
        [JsonProperty(PropertyName = "can_change_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_change_info { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can invite new users to the chat.</summary>
        [JsonProperty(PropertyName = "can_invite_users", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_invite_users { get; set; }
        ///<summary>Optional. Administrators only. True, if the administrator can pin messages, supergroups only.</summary>
        [JsonProperty(PropertyName = "can_pin_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_pin_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is a member of the chat at the moment of the request.</summary>
        [JsonProperty(PropertyName = "is_member", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_member { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send text messages, contacts, locations and venues.</summary>
        [JsonProperty(PropertyName = "can_send_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send audios, documents, photos, videos, video notes and voice notes, implies can_send_messages.</summary>
        [JsonProperty(PropertyName = "can_send_media_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_media_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if the user is allowed to send polls.</summary>
        [JsonProperty(PropertyName = "can_send_polls", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_polls { get; set; }
        ///<summary>Optional. Restricted only. True, if the user can send animations, games, stickers and use inline bots, implies can_send_media_messages.</summary>
        [JsonProperty(PropertyName = "can_send_other_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_other_messages { get; set; }
        ///<summary>Optional. Restricted only. True, if user may add web page previews to his messages, implies can_send_media_messages.</summary>
        [JsonProperty(PropertyName = "can_add_web_page_previews", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_add_web_page_previews { get; set; }
    }
}