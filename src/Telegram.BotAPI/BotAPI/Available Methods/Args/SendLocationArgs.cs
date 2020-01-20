// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendLocation method arguments.</summary>
    public sealed class SendLocationArgs : BaseSendArgs
    {
        ///<summary>Latitude of the location.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        ///<summary>Longitude of the location.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        ///<summary>Optional. Period in seconds for which the location will be updated, should be between 60 and 86400.</summary>
        [JsonPropertyName("live_period")]
        public uint Live_period { get; set; }
    }
}