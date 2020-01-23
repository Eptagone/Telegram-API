﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represents one button of the reply keyboard. For simple text buttons String can be used instead of this object to specify text of the button. Optional fields are mutually exclusive.</summary>
    public sealed class KeyboardButton
    {
        /// <summary>Creates a new keyboard button.</summary>
        /// <param name="text">Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed.</param>
        public KeyboardButton(string text)
        {
            Text = text;
        }
        ///<summary>Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed.</summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
        ///<summary>Optional. If True, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only.</summary>
        [JsonPropertyName("request_contact")]
        public bool Request_contact { get; set; }
        ///<summary>Optional. If True, the user's current location will be sent when the button is pressed. Available in private chats only.</summary>
        [JsonPropertyName("request_location")]
        public bool Request_location { get; set; }
        ///<summary>Optional. If specified, the user will be asked to create a poll and send it to the bot when the button is pressed. Available in private chats only.</summary>
        [JsonPropertyName("request_poll")]
        public KeyboardButtonPollType Request_poll { get; set; }
    }
}