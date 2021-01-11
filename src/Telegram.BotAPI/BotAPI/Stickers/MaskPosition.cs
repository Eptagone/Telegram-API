// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Stickers
{
    ///<summary>This object describes the position on faces where a mask should be placed by default.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class MaskPosition
    {
        ///<summary>The part of the face relative to which the mask should be placed. One of “forehead”, “eyes”, “mouth”, or “chin”.</summary>
        [JsonPropertyName("point")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Point { get; set; }
        ///<summary>Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. For example, choosing -1.0 will place mask just to the left of the default mask position.</summary>
        [JsonPropertyName("x_shift")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float X_shift { get; set; }
        ///<summary>Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. For example, 1.0 will place the mask just below the default mask position.</summary>
        [JsonPropertyName("y_shift")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Y_shift { get; set; }
        ///<summary>Mask scaling coefficient. For example, 2.0 means double size.</summary>
        [JsonPropertyName("scale")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Scale { get; set; }
    }
}