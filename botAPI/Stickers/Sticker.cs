using Newtonsoft.Json;

namespace TelegramAPI.Stickers
{
    ///<summary>This object represents a sticker.</summary>
    public class Sticker
    {
        ///<summary>Unique identifier for this file.</summary>
        [JsonProperty(PropertyName = "file_id", Required = Required.Always)]
        public string File_id { get; set; }
        ///<summary>Sticker width.</summary>
        [JsonProperty(PropertyName = "width", Required = Required.Always)]
        public uint Width { get; set; }
        ///<summary>Sticker height.</summary>
        [JsonProperty(PropertyName = "height", Required = Required.Always)]
        public uint Height { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonProperty(PropertyName = "is_animated", Required = Required.Always)]
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