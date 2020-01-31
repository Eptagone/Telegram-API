using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>UploadStickerFile method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class UploadStickerFileArgs
    {
        /// <summary>User identifier of sticker file owner.</summary>
        [JsonPropertyName("user_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        /// <summary>Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</summary>
        [JsonPropertyName("png_sticker")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile Png_sticker { get; set; }
    }
}
