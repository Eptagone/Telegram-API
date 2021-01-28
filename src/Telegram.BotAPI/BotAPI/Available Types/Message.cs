// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Games;
using Telegram.BotAPI.Payments;
using Telegram.BotAPI.Stickers;
using Telegram.BotAPI.TelegramPassport;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a message.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Message : IReplyMarkup<InlineKeyboardMarkup>
    {
        /// <summary>Unique message identifier inside this chat.</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint MessageId { get; set; }
        /// <summary>Optional. Sender, empty for messages sent to channels.</summary>
        [JsonPropertyName(PropertyNames.From)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }
        /// <summary>Optional. Sender of the message, sent on behalf of a chat. The channel itself for channel messages. The supergroup itself for messages from anonymous group administrators. The linked channel for messages automatically forwarded to the discussion group.</summary>
        [JsonPropertyName(PropertyNames.SenderChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat SenderChat { get; set; }
        /// <summary>Date the message was sent in Unix time.</summary>
        [JsonPropertyName(PropertyNames.Date)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Date { get; set; }
        /// <summary>Conversation the message belongs to.</summary>
        [JsonPropertyName(PropertyNames.Chat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Chat { get; set; }
        /// <summary>Optional. For forwarded messages, sender of the original message.</summary>
        [JsonPropertyName(PropertyNames.ForwardFrom)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User ForwardFrom { get; set; }
        /// <summary>Optional. For messages forwarded from channels, information about the original channel.</summary>
        [JsonPropertyName(PropertyNames.ForwardFromChat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat ForwardFromChat { get; set; }
        /// <summary>Optional. For messages forwarded from channels, identifier of the original message in the channel.</summary>
        [JsonPropertyName(PropertyNames.ForwardFromMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ForwardFromMessageId { get; set; }
        /// <summary>Optional. For messages forwarded from channels, signature of the post author if present.</summary>
        [JsonPropertyName(PropertyNames.ForwardSignature)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ForwardSignature { get; set; }
        /// <summary>Optional. Sender's name for messages forwarded from users who disallow adding a link to their account in forwarded messages.</summary>
        [JsonPropertyName(PropertyNames.ForwardSenderName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ForwardSenderName { get; set; }
        /// <summary>Optional. For forwarded messages, date the original message was sent in Unix time.</summary>
        [JsonPropertyName(PropertyNames.ForwardDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ForwardDate { get; set; }
        ///<summary>Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.</summary>
        [JsonPropertyName(PropertyNames.ReplyToMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message ReplyToMessage { get; set; }
        ///<summary>Optional. Bot through which the message was sent.</summary>
        [JsonPropertyName(PropertyNames.ViaBot)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User ViaBot { get; set; }
        ///<summary>Optional. Date the message was last edited in Unix time.</summary>
        [JsonPropertyName(PropertyNames.EditDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint EditDate { get; set; }
        ///<summary>Optional. The unique identifier of a media message group this message belongs to.</summary>
        [JsonPropertyName(PropertyNames.MediaGroupId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MediaGroupId { get; set; }
        ///<summary>Optional. Signature of the post author for messages in channels.</summary>
        [JsonPropertyName(PropertyNames.AuthorSignature)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AuthorSignature { get; set; }
        ///<summary>Optional. For text messages, the actual UTF-8 text of the message, 0-4096 characters.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text.</summary>
        [JsonPropertyName(PropertyNames.Entities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] Entities { get; set; }
        ///<summary>Optional. Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set.</summary>
        [JsonPropertyName(PropertyNames.Animation)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Animation Animation { get; set; }
        ///<summary>Optional. Message is an audio file, information about the file.</summary>
        [JsonPropertyName(PropertyNames.Audio)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Audio Audio { get; set; }
        ///<summary>Optional. Message is a general file, information about the file.</summary>
        [JsonPropertyName(PropertyNames.Document)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Document Document { get; set; }
        ///<summary>Optional. Message is a photo, available sizes of the photo.</summary>
        [JsonPropertyName(PropertyNames.Photo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[] Photo { get; set; }
        ///<summary>Optional. Message is a sticker, information about the sticker.</summary>
        [JsonPropertyName(PropertyNames.Sticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Sticker Sticker { get; set; }
        ///<summary>Optional. Message is a video, information about the video.</summary>
        [JsonPropertyName(PropertyNames.Video)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Video Video { get; set; }
        ///<summary>Optional. Message is a video note, information about the video message.</summary>
        [JsonPropertyName(PropertyNames.VideoNote)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VideoNote VideoNote { get; set; }
        ///<summary>Optional. Message is a voice message, information about the file.</summary>
        [JsonPropertyName(PropertyNames.Voice)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Voice Voice { get; set; }
        ///<summary>Optional. Caption for the audio, document, photo, video or voice, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption.</summary>
        [JsonPropertyName(PropertyNames.CaptionEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] CaptionEntities { get; set; }
        ///<summary>Optional. Message is a shared contact, information about the contact.</summary>
        [JsonPropertyName(PropertyNames.Contact)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Contact Contact { get; set; }
        ///<summary>Optional. Message is a dice with random value from 1 to 6</summary>
        [JsonPropertyName(PropertyNames.Dice)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dice Dice { get; set; }
        ///<summary>Optional. Message is a game, information about the game.</summary>
        [JsonPropertyName(PropertyNames.Game)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Game Game { get; set; }
        ///<summary>Optional. Message is a native poll, information about the poll.</summary>
        [JsonPropertyName(PropertyNames.Poll)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Poll Poll { get; set; }
        ///<summary>Optional. Message is a venue, information about the venue.</summary>
        [JsonPropertyName(PropertyNames.Venue)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Venue Venue { get; set; }
        ///<summary>Optional. Message is a shared location, information about the location.</summary>
        [JsonPropertyName(PropertyNames.Location)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
        ///<summary>Optional. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members).</summary>
        [JsonPropertyName(PropertyNames.NewChatMembers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User[] NewChatMembers { get; set; }
        ///<summary>Optional. A member was removed from the group, information about them (this member may be the bot itself).</summary>
        [JsonPropertyName(PropertyNames.LeftChatMember)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User LeftChatMember { get; set; }
        ///<summary>Optional. A chat title was changed to this value.</summary>
        [JsonPropertyName(PropertyNames.NewChatTitle)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NewChatTitle { get; set; }
        ///<summary>Optional. A chat photo was change to this value.</summary>
        [JsonPropertyName(PropertyNames.NewChatPhoto)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[] NewChatPhoto { get; set; }
        ///<summary>Optional. Service message: the chat photo was deleted.</summary>
        [JsonPropertyName(PropertyNames.DeleteChatPhoto)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DeleteChatPhoto { get; set; }
        ///<summary>Optional. Service message: the group has been created.</summary>
        [JsonPropertyName(PropertyNames.GroupChatCreated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool GroupChatCreated { get; set; }
        ///<summary>Optional. Service message: the supergroup has been created. This field can‘t be received in a message coming through updates, because bot can’t be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.</summary>
        [JsonPropertyName(PropertyNames.SupergroupChatCreated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupergroupChatCreated { get; set; }
        ///<summary>Optional. Service message: the channel has been created. This field can‘t be received in a message coming through updates, because bot can’t be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.</summary>
        [JsonPropertyName(PropertyNames.ChannelChatCreated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ChannelChatCreated { get; set; }
        ///<summary>Optional. The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonPropertyName(PropertyNames.MigrateToChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MigrateToChatId { get; set; }
        ///<summary>Optional. The supergroup has been migrated from a group with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.</summary>
        [JsonPropertyName(PropertyNames.MigrateFromChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MigrateFromChatId { get; set; }
        ///<summary>Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.</summary>
        [JsonPropertyName(PropertyNames.PinnedMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message PinnedMessage { get; set; }
        ///<summary>Optional. Message is an invoice for a payment, information about the invoice.</summary>
        [JsonPropertyName(PropertyNames.Invoice)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Invoice Invoice { get; set; }
        ///<summary>Optional. Message is a service message about a successful payment, information about the payment.</summary>
        [JsonPropertyName(PropertyNames.SuccessfulPayment)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SuccessfulPayment SuccessfulPayment { get; set; }
        ///<summary>Optional. The domain name of the website on which the user has logged in.</summary>
        [JsonPropertyName(PropertyNames.ConnectedWebsite)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConnectedWebsite { get; set; }
        ///<summary>Optional. Telegram Passport data.</summary>
        [JsonPropertyName(PropertyNames.PassportData)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportData PassportData { get; set; }
        ///<summary>Optional. Service message. A user in the chat triggered another user's proximity alert while sharing Live Location.</summary>
        [JsonPropertyName(PropertyNames.ProximityAlertTriggered)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ProximityAlertTriggered ProximityAlertTriggered { get; set; }

        ///<summary>Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}
