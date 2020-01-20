// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>This object represents a game. Use BotFather to create and edit games, their short names will act as unique identifiers.</summary>
    public sealed class Game
    {
        /// <summary>Title of the game.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>Description of the game.</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>Photo that will be displayed in the game message in chats.</summary>
        [JsonPropertyName("photo")]
        public Available_Types.PhotoSize[] Photo { get; set; }
        /// <summary>Optional. Brief description of the game or high scores included in the game message. Can be automatically edited to include current high scores for the game when the bot calls setGameScore, or manually edited using editMessageText. 0-4096 characters.</summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
        /// <summary>Optional. Special entities that appear in text, such as usernames, URLs, bot commands, etc.</summary>
        [JsonPropertyName("text_entities")]
        public Available_Types.MessageEntity[] Text_entities { get; set; }
        /// <summary>Optional. Animation that will be displayed in the game message in chats. Upload via BotFather.</summary>
        [JsonPropertyName("animation")]
        public Available_Types.Animation Animation { get; set; }
    }
}