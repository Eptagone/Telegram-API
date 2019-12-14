using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>Describes actions that a non-administrator user is allowed to take in a chat.</summary>
    public class ChatPermissions
    {
        ///<summary>Optional. True, if the user is allowed to send text messages, contacts, locations and venues.</summary>
        [JsonProperty(PropertyName = "can_send_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_messages { get; set; }
        ///<summary>Optional. True, if the user is allowed to send audios, documents, photos, videos, video notes and voice notes, implies can_send_messages.</summary>
        [JsonProperty(PropertyName = "can_send_media_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_media_messages { get; set; }
        ///<summary>Optional. True, if the user is allowed to send polls, implies can_send_messages.</summary>
        [JsonProperty(PropertyName = "can_send_polls", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_polls { get; set; }
        ///<summary>Optional. True, if the user is allowed to send animations, games, stickers and use inline bots, implies can_send_media_messages.</summary>
        [JsonProperty(PropertyName = "can_send_other_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_send_other_messages { get; set; }
        ///<summary>Optional. True, if the user is allowed to add web page previews to their messages, implies can_send_media_messages.</summary>
        [JsonProperty(PropertyName = "can_add_web_page_previews", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_add_web_page_previews { get; set; }
        ///<summary>Optional. True, if the user is allowed to change the chat title, photo and other settings. Ignored in public supergroups.</summary>
        [JsonProperty(PropertyName = "can_change_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_change_info { get; set; }
        ///<summary>Optional. True, if the user is allowed to invite new users to the chat.</summary>
        [JsonProperty(PropertyName = "can_invite_users", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_invite_users { get; set; }
        ///<summary>Optional. True, if the user is allowed to pin messages. Ignored in public supergroups.</summary>
        [JsonProperty(PropertyName = "can_pin_messages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Can_pin_messages { get; set; }
    }
}
