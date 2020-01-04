// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Stickers
{
    /// <summary>This object represents a sticker set.</summary>
    public sealed class StickerSet
    {
        ///<summary>Sticker set name.</summary>
        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        ///<summary>Sticker set title.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonProperty(PropertyName = "is_animated", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_animated { get; set; }
        ///<summary>True, if the sticker set contains masks.</summary>
        [JsonProperty(PropertyName = "contains_masks", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Contains_masks { get; set; }
        ///<summary>List of all set stickers.</summary>
        [JsonProperty(PropertyName = "stickers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Sticker[] Stickers { get; set; }
    }
}