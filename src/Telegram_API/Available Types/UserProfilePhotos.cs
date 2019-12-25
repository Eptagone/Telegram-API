// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>This object represent a user's profile pictures.</summary>
    public class UserProfilePhotos
    {
        ///<summary>Total number of profile pictures the target user has.</summary>
        [JsonProperty(PropertyName = "total_count", Required = Required.Always)]
        public uint Total_count { get; set; }
        ///<summary>Requested profile pictures (in up to 4 sizes each).</summary>
        [JsonProperty(PropertyName = "photos", Required = Required.Always)]
        public PhotoSize[][] Photos { get; set; }
    }
}