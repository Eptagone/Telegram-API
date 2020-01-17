// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>This object represent a user's profile pictures.</summary>
    public sealed class UserProfilePhotos
    {
        ///<summary>Total number of profile pictures the target user has.</summary>
        [JsonProperty(PropertyName = "total_count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Total_count { get; set; }
        ///<summary>Requested profile pictures (in up to 4 sizes each).</summary>
        [JsonProperty(PropertyName = "photos", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[][] Photos { get; set; }
    }
}