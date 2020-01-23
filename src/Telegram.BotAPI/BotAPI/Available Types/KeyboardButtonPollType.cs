// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents type of a poll, which is allowed to be created and sent when the corresponding button is pressed.</summary>
    public class KeyboardButtonPollType
    {
        /// <summary>Optional. If quiz is passed, the user will be allowed to create only polls in the quiz mode. If regular is passed, only regular polls will be allowed. Otherwise, the user will be allowed to create a poll of any type.</summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
