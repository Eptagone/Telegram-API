using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a contact with a phone number. By default, this contact will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the contact.</summary>
    public class InlineQueryResultContact : InlineQueryResult
    {
        /// <summary>Type of the result, must be contact.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "contact";
        /// <summary>Contact's phone number.</summary>
        [JsonProperty(PropertyName = "phone_number", Required = Required.Always)]
        public string Phone_number { get; set; }
        /// <summary>Contact's first name.</summary>
        [JsonProperty(PropertyName = "first_name", Required = Required.Always)]
        public string First_name { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        [JsonProperty(PropertyName = "last_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_name { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes.</summary>
        [JsonProperty(PropertyName = "vcard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Vcard { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the contact.</summary>
        [JsonProperty(PropertyName = "input_message_content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public new InputMessageContent Input_message_content { get; set; }
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb_url { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonProperty(PropertyName = "thumb_width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_width { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonProperty(PropertyName = "thumb_height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Thumb_height { get; set; }
    }
}
