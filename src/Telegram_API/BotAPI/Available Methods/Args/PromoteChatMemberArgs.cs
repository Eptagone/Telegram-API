// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>PromoteChatMember method arguments.</summary>
    public sealed class PromoteChatMemberArgs
    {
        ///<summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>Unique identifier of the target user.</summary>
        [JsonProperty(PropertyName = "user_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        ///<summary>Optional. Pass True, if the administrator can change chat title, photo and other settings.</summary>
        [JsonProperty(PropertyName = "can_change_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_change_info { get; set; }
        ///<summary>Optional. Pass True, if the administrator can create channel posts, channels only.</summary>
        [JsonProperty(PropertyName = "can_post_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_post_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</summary>
        [JsonProperty(PropertyName = "can_edit_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_edit_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can delete messages of other users.</summary>
        [JsonProperty(PropertyName = "can_delete_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_delete_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can invite new users to the chat..</summary>
        [JsonProperty(PropertyName = "can_invite_users", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_invite_users { get; set; }
        ///<summary>Optional. Pass True, if the administrator can restrict, ban or unban chat members.</summary>
        [JsonProperty(PropertyName = "can_restrict_members", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_restrict_members { get; set; }
        ///<summary>Optional. Pass True, if the administrator can pin messages, supergroups only.</summary>
        [JsonProperty(PropertyName = "can_pin_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_pin_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</summary>
        [JsonProperty(PropertyName = "can_promote_members", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_promote_members { get; set; }
    }
}