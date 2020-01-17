using Newtonsoft.Json;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>AddStickerToSet method arguments.</summary>
    public sealed class AddStickerToSetArgs
    {
        /// <summary>User identifier of sticker set owner.</summary>
        [JsonProperty(PropertyName = "user_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        /// <summary>Sticker set name.</summary>
        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "png_sticker", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [InputFile("png_sticker")]
        public object Png_sticker { get; set; }
        /// <summary>One or more emoji corresponding to the sticker.</summary>
        [JsonProperty(PropertyName = "user_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emojis { get; set; }
        /// <summary>Optional. A <see cref="MaskPosition"/> object for position where the mask should be placed on faces.</summary>
        [JsonProperty(PropertyName = "mask_position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition Mask_position { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
    }
}
