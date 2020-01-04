using Newtonsoft.Json;
using TelegramAPI.Available_Types;
namespace TelegramAPI.Stickers
{
    /// <summary>UploadStickerFile method arguments.</summary>
    public sealed class UploadStickerFileArgs
    {
        /// <summary>User identifier of sticker file owner.</summary>
        [JsonProperty(PropertyName = "user_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</summary>
        [JsonProperty(PropertyName = "png_sticker", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile Png_sticker { get; set; }
    }
}
