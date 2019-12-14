namespace TelegramAPI.Stickers
{
    public static partial class Stickers
    {
        /// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static Available_Types.Message SendSticker(this BotClient T, SendStickerArgs args) => T.RPC<Available_Types.Message>("sendSticker", args);
    }
}