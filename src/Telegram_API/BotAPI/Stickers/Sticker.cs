﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Stickers
{
    ///<summary>This object represents a sticker.</summary>
    public sealed class Sticker
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_unique_id { get; set; }
        ///<summary>Sticker width.</summary>
        [JsonProperty(PropertyName = "width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Sticker height.</summary>
        [JsonProperty(PropertyName = "height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonProperty(PropertyName = "is_animated", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_animated { get; set; }
        ///<summary>Optional. Sticker thumbnail in the .webp or .jpg format.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.PhotoSize Thumb { get; set; }
        ///<summary>Optional. Emoji associated with the sticker.</summary>
        [JsonProperty(PropertyName = "emoji", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emoji { get; set; }
        ///<summary>Optional. Name of the sticker set to which the sticker belongs.</summary>
        [JsonProperty(PropertyName = "set_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Set_name { get; set; }
        ///<summary>Optional. For mask stickers, the position where the mask should be placed.</summary>
        [JsonProperty(PropertyName = "mask_position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition Mask_position { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
    }
}