﻿// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>This object represents a sticker set.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class StickerSet
    {
        ///<summary>Sticker set name.</summary>
        [JsonPropertyName("name")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        ///<summary>Sticker set title.</summary>
        [JsonPropertyName("title")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonPropertyName("is_animated")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_animated { get; set; }
        ///<summary>True, if the sticker set contains masks.</summary>
        [JsonPropertyName("contains_masks")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Contains_masks { get; set; }
        ///<summary>List of all set stickers.</summary>
        [JsonPropertyName("stickers")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Sticker[] Stickers { get; set; }
        ///<summary>Optional. Sticker set thumbnail in the .WEBP or .TGS format.</summary>
        [JsonPropertyName("thumb")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
    }
}