namespace TelegramAPI.Stickers
{
    public static partial class Stickers
    {
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool CreateNewStickerSet(this BotClient T, CreateNewStickerSetArgs args) => T.RPC<bool>("createNewStickerSet", args);
    }
}