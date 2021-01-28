// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Stickers
{
    ///<summary>This object represents a sticker.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Sticker
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName(PropertyNames.FileId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileId { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName(PropertyNames.FileUniqueId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileUniqueId { get; set; }
        ///<summary>Sticker width.</summary>
        [JsonPropertyName(PropertyNames.Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Sticker height.</summary>
        [JsonPropertyName(PropertyNames.Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonPropertyName(PropertyNames.IsAnimated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnimated { get; set; }
        ///<summary>Optional. Sticker thumbnail in the .webp or .jpg format.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvailableTypes.PhotoSize Thumb { get; set; }
        ///<summary>Optional. Emoji associated with the sticker.</summary>
        [JsonPropertyName(PropertyNames.Emoji)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emoji { get; set; }
        ///<summary>Optional. Name of the sticker set to which the sticker belongs.</summary>
        [JsonPropertyName(PropertyNames.SetName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SetName { get; set; }
        ///<summary>Optional. For mask stickers, the position where the mask should be placed.</summary>
        [JsonPropertyName(PropertyNames.MaskPosition)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition MaskPosition { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName(PropertyNames.FileSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileSize { get; set; }
    }
}