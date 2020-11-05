// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>PromoteChatMember method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PromoteChatMemberArgs
    {
        ///<summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName("chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>Unique identifier of the target user.</summary>
        [JsonPropertyName("user_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        ///<summary>Pass True, if the administrator's presence in the chat is hidden.</summary>
        [JsonPropertyName("is_anonymous")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_anonymous { get; set; }
        ///<summary>Optional. Pass True, if the administrator can change chat title, photo and other settings.</summary>
        [JsonPropertyName("can_change_info")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_change_info { get; set; }
        ///<summary>Optional. Pass True, if the administrator can create channel posts, channels only.</summary>
        [JsonPropertyName("can_post_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_post_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can edit messages of other users and can pin messages, channels only.</summary>
        [JsonPropertyName("can_edit_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_edit_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can delete messages of other users.</summary>
        [JsonPropertyName("can_delete_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_delete_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can invite new users to the chat.</summary>
        [JsonPropertyName("can_invite_users")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_invite_users { get; set; }
        ///<summary>Optional. Pass True, if the administrator can restrict, ban or unban chat members.</summary>
        [JsonPropertyName("can_restrict_members")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_restrict_members { get; set; }
        ///<summary>Optional. Pass True, if the administrator can pin messages, supergroups only.</summary>
        [JsonPropertyName("can_pin_messages")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_pin_messages { get; set; }
        ///<summary>Optional. Pass True, if the administrator can add new administrators with a subset of his own privileges or demote administrators that he has promoted, directly or indirectly (promoted by administrators that were appointed by him).</summary>
        [JsonPropertyName("can_promote_members")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_promote_members { get; set; }
    }
}
