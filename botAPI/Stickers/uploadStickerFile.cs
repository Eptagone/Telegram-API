using Newtonsoft.Json.Linq;

namespace TelegramAPI.Stickers
{
    public static partial class Stickers
    {
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker file owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</param>
        public static Available_Types.File UploadStickerFile(this BotClient T, int user_id, object png_sticker) => T.RPC<Available_Types.File>("uploadStickerFile", new JObject { new JProperty("user_id", user_id), new JProperty("png_sticker", png_sticker) });
    }
}