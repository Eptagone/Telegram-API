// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represent a user's profile pictures.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class UserProfilePhotos
    {
        ///<summary>Total number of profile pictures the target user has.</summary>
        [JsonPropertyName(PropertyNames.TotalCount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint TotalCount { get; set; }
        ///<summary>Requested profile pictures (in up to 4 sizes each).</summary>
        [JsonPropertyName(PropertyNames.Photos)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize[][] Photos { get; set; }
    }
}