using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>AddStickerToSet method arguments.</summary>
    public sealed class AddStickerToSetArgs
    {
        /// <summary>User identifier of sticker set owner.</summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; }
        /// <summary>Sticker set name.</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName("png_sticker")]
        [InputFile("png_sticker")]
        public object Png_sticker { get; set; }
        /// <summary>One or more emoji corresponding to the sticker.</summary>
        [JsonPropertyName("user_id")]
        public string Emojis { get; set; }
        /// <summary>Optional. A <see cref="MaskPosition"/> object for position where the mask should be placed on faces.</summary>
        [JsonPropertyName("mask_position")]
        public MaskPosition Mask_position { get; set; }
        internal bool UseMultipart()
        {
            if (Png_sticker != default)
                if (Png_sticker.GetType() == typeof(InputFile))
                    return true;
            return false;
        }
    }
}
