// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Stickers
{
    ///<summary>This object represents a sticker.</summary>
    public sealed class Sticker
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName("file_id")]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName("file_unique_id")]
        public string File_unique_id { get; set; }
        ///<summary>Sticker width.</summary>
        [JsonPropertyName("width")]
        public uint Width { get; set; }
        ///<summary>Sticker height.</summary>
        [JsonPropertyName("height")]
        public uint Height { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonPropertyName("is_animated")]
        public bool Is_animated { get; set; }
        ///<summary>Optional. Sticker thumbnail in the .webp or .jpg format.</summary>
        [JsonPropertyName("thumb")]
        public Available_Types.PhotoSize Thumb { get; set; }
        ///<summary>Optional. Emoji associated with the sticker.</summary>
        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }
        ///<summary>Optional. Name of the sticker set to which the sticker belongs.</summary>
        [JsonPropertyName("set_name")]
        public string Set_name { get; set; }
        ///<summary>Optional. For mask stickers, the position where the mask should be placed.</summary>
        [JsonPropertyName("mask_position")]
        public MaskPosition Mask_position { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName("file_size")]
        public uint File_size { get; set; }
    }
}