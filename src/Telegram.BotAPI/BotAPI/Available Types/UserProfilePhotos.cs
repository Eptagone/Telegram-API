﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represent a user's profile pictures.</summary>
    public sealed class UserProfilePhotos
    {
        ///<summary>Total number of profile pictures the target user has.</summary>
        [JsonPropertyName("total_count")]
        public uint Total_count { get; set; }
        ///<summary>Requested profile pictures (in up to 4 sizes each).</summary>
        [JsonPropertyName("photos")]
        public PhotoSize[][] Photos { get; set; }
    }
}