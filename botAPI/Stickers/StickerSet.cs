using Newtonsoft.Json;

namespace TelegramAPI.Stickers
{
    /// <summary>This object represents a sticker set.</summary>
    public class StickerSet
    {
        ///<summary>Sticker set name.</summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; set; }
        ///<summary>Sticker set title.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonProperty(PropertyName = "is_animated", Required = Required.Always)]
        public bool Is_animated { get; set; }
        ///<summary>True, if the sticker set contains masks.</summary>
        [JsonProperty(PropertyName = "contains_masks", Required = Required.Always)]
        public bool Contains_masks { get; set; }
        ///<summary>List of all set stickers.</summary>
        [JsonProperty(PropertyName = "stickers", Required = Required.Always)]
        public Sticker[] Stickers { get; set; }
    }
}