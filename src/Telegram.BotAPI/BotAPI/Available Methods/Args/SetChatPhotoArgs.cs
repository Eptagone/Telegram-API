// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SetChatPhoto method arguments.</summary>
    public sealed class SetChatPhotoArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName("chat_id")]
        public object Chat_id { get; set; }
        /// <summary>New chat photo, uploaded using multipart/form-data.</summary>
        [JsonPropertyName("photo")]
        public InputFile Photo { get; set; }
    }
}
