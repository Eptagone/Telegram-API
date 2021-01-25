// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a message.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Message
    {
        /// <summary>Unique message identifier inside this chat.</summary>
        [JsonPropertyName("message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        /// <summary>Optional. Sender, empty for messages sent to channels.</summary>
        [JsonPropertyName("from")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }
        /// <summary>Optional. Sender of the message, sent on behalf of a chat. The channel itself for channel messages. The supergroup itself for messages from anonymous group administrators. The linked channel for messages automatically forwarded to the discussion group.</summary>
        [JsonPropertyName("sender_chat")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Sender_chat { get; set; }
        /// <summary>Date the message was sent in Unix time.</summary>
        [JsonPropertyName("date")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Date { get; set; }
        /// <summary>Conversation the message belongs to.</summary>
        [JsonPropertyName("chat")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Chat { get; set; }
        /// <summary>Optional. For forwarded messages, sender of the original message.</summary>
        [JsonPropertyName("forward_from")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Forward_from { get; set; }
        /// <summary>Optional. For messages forwarded from channels, information about the original channel.</summary>
        [JsonPropertyName("forward_from_chat")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Forward_from_chat { get; set; }
        /// <summary>Optional. For messages forwarded from channels, identifier of the original message in the channel.</summary>
        [JsonPropertyName("forward_from_message_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Forward_from_message_id { get; set; }
        /// <summary>Optional. For messages forwarded from channels, signature of the post author if present.</summary>
        [JsonPropertyName("forward_signature")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Forward_signature { get; set; }
        /// <summary>Optional. Sender's name for messages forwarded from users who disallow adding a link to their account in forwarded messages.</summary>
        [JsonPropertyName("forward_sender_name")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Forward_sender_name { get; set; }
        /// <summary>Optional. For forwarded messages, date the original message was sent in Unix time.</summary>
        [JsonPropertyName("forward_date")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Forward_date { get; set; }
        ///<summary>Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.</summary>
        [JsonPropertyName("reply_to_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Reply_to_message { get; set; }
        ///<summary>Optional. Bot through which the message was sent.</summary>
        [JsonPropertyName("via_bot")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Via_bot { get; set; }
        ///<summary>Optional. Date the message was last edited in Unix time.</summary>
        [JsonPropertyName("edit_date")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Edit_date { get; set; }
        ///<summary>Optional. The unique identifier of a media message group this message belongs to.</summary>
        [JsonPropertyName("media_group_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media_group_id { get; set; }
        ///<summary>Optional. Signature of the post author for messages in channels.</summary>
        [JsonPropertyName("author_signature")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Author_signature { get; set; }
        ///<summary>Optional. For text messages, the actual UTF-8 text of the message, 0-4096 characters.</summary>
        [JsonPropertyName("text")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text.</summary>
        [JsonPropertyName("entities")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Entities { get; set; }
        ///<summary>Optional. Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set.</summary>
        [JsonPropertyName("animation")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Animation Animation { get; set; }
        ///<summary>Optional. Message is an audio file, information about the file.</summary>
        [JsonPropertyName("audio")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Audio Audio { get; set; }
        ///<summary>Optional. Message is a general file, information about the file.</summary>
        [JsonPropertyName("document")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Document Document { get; set; }
        ///<summary>Optional. Message is a photo, available sizes of the photo.</summary>
        [JsonPropertyName("photo")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PhotoSize> Photo { get; set; }
        ///<summary>Optional. Message is a sticker, information about the sticker.</summary>
        [JsonPropertyName("sticker")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Stickers.Sticker Sticker { get; set; }
        ///<summary>Optional. Message is a video, information about the video.</summary>
        [JsonPropertyName("video")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Video Video { get; set; }
        ///<summary>Optional. Message is a video note, information about the video message.</summary>
        [JsonPropertyName("video_note")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VideoNote Video_note { get; set; }
        ///<summary>Optional. Message is a voice message, information about the file.</summary>
        [JsonPropertyName("voice")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Voice Voice { get; set; }
        ///<summary>Optional. Caption for the audio, document, photo, video or voice, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption.</summary>
        [JsonPropertyName("caption_entities")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Caption_entities { get; set; }
        ///<summary>Optional. Message is a shared contact, information about the contact.</summary>
        [JsonPropertyName("contact")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Contact Contact { get; set; }
        ///<summary>Optional. Message is a dice with random value from 1 to 6</summary>
        [JsonPropertyName("dice")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dice Dice { get; set; }
        ///<summary>Optional. Message is a game, information about the game.</summary>
        [JsonPropertyName("game")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Games.Game Game { get; set; }
        ///<summary>Optional. Message is a native poll, information about the poll.</summary>
        [JsonPropertyName("poll")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Poll Poll { get; set; }
        ///<summary>Optional. Message is a venue, information about the venue.</summary>
        [JsonPropertyName("venue")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Venue Venue { get; set; }
        ///<summary>Optional. Message is a shared location, information about the location.</summary>
        [JsonPropertyName("location")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Optional. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members).</summary>
        [JsonPropertyName("new_chat_members")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<User> New_chat_members { get; set; }
        ///<summary>Optional. A member was removed from the group, information about them (this member may be the bot itself).</summary>
        [JsonPropertyName("left_chat_member")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Left_chat_member { get; set; }
        ///<summary>Optional. A chat title was changed to this value.</summary>
        [JsonPropertyName("new_chat_title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string New_chat_title { get; set; }
        ///<summary>Optional. A chat photo was change to this value.</summary>
        [JsonPropertyName("new_chat_photo")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PhotoSize> New_chat_photo { get; set; }
        ///<summary>Optional. Service message: the chat photo was deleted.</summary>
        [JsonPropertyName("delete_chat_photo")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Delete_chat_photo { get; set; }
        ///<summary>Optional. Service message: the group has been created.</summary>
        [JsonPropertyName("group_chat_created")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Group_chat_created { get; set; }
        ///<summary>Optional. Service message: the supergroup has been created. This field can‘t be received in a message coming through updates, because bot can’t be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.</summary>
        [JsonPropertyName("supergroup_chat_created")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Supergroup_chat_created { get; set; }
        ///<summary>Optional. Service message: the channel has been created. This field can‘t be received in a message coming through updates, because bot can’t be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.</summary>
        [JsonPropertyName("channel_chat_created")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Channel_chat_created { get; set; }
        ///<summary>Optional. The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonPropertyName("migrate_to_chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Migrate_to_chat_id { get; set; }
        ///<summary>Optional. The supergroup has been migrated from a group with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonPropertyName("migrate_from_chat_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Migrate_from_chat_id { get; set; }
        ///<summary>Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.</summary>
        [JsonPropertyName("pinned_message")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Pinned_message { get; set; }
        ///<summary>Optional. Message is an invoice for a payment, information about the invoice.</summary>
        [JsonPropertyName("invoice")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payments.Invoice Invoice { get; set; }
        ///<summary>Optional. Message is a service message about a successful payment, information about the payment.</summary>
        [JsonPropertyName("successful_payment")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payments.SuccessfulPayment Successful_payment { get; set; }
        ///<summary>Optional. The domain name of the website on which the user has logged in.</summary>
        [JsonPropertyName("connected_website")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Connected_website { get; set; }
        ///<summary>Optional. Telegram Passport data.</summary>
        [JsonPropertyName("passport_data")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Telegram_Passport.PassportData Passport_data { get; set; }
        ///<summary>Optional. Service message. A user in the chat triggered another user's proximity alert while sharing Live Location.</summary>
        [JsonPropertyName("proximity_alert_triggered")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ProximityAlertTriggered Proximity_alert_triggered { get; set; }
        ///<summary>Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons.</summary>
        [JsonPropertyName("reply_markup")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
