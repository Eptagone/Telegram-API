// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>This object represents a sticker set.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class StickerSet
    {
        ///<summary>Sticker set name.</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        ///<summary>Sticker set title.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonPropertyName(PropertyNames.IsAnimated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnimated { get; set; }
        ///<summary>True, if the sticker set contains masks.</summary>
        [JsonPropertyName(PropertyNames.ContainsMasks)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ContainsMasks { get; set; }
        ///<summary>List of all set stickers.</summary>
        [JsonPropertyName(PropertyNames.Stickers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<Sticker> Stickers { get; set; }
        ///<summary>Optional. Sticker set thumbnail in the .WEBP or .TGS format.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
    }
}