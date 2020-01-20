using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;
namespace Telegram.BotAPI.Stickers
{
    /// <summary>UploadStickerFile method arguments.</summary>
    public sealed class UploadStickerFileArgs
    {
        /// <summary>User identifier of sticker file owner.</summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</summary>
        [JsonPropertyName("png_sticker")]
        public InputFile Png_sticker { get; set; }
    }
}
