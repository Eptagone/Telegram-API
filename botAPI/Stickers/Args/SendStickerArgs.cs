using Newtonsoft.Json;

namespace TelegramAPI.Stickers
{
    /// <summary>SendSticker method arguments</summary>
    public class SendStickerArgs : Available_Methods.BaseSendArgs
    {
        /// <summary>Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "sticker", Required = Required.Always)]
        public object Sticker { get; set; }
    }
}