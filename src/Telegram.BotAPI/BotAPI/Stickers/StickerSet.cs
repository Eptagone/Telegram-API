// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Stickers
{
    /// <summary>This object represents a sticker set.</summary>
    public sealed class StickerSet
    {
        ///<summary>Sticker set name.</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        ///<summary>Sticker set title.</summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonPropertyName("is_animated")]
        public bool Is_animated { get; set; }
        ///<summary>True, if the sticker set contains masks.</summary>
        [JsonPropertyName("contains_masks")]
        public bool Contains_masks { get; set; }
        ///<summary>List of all set stickers.</summary>
        [JsonPropertyName("stickers")]
        public Sticker[] Stickers { get; set; }
    }
}