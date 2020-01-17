// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>SendSticker method arguments</summary>
    public sealed class SendStickerArgs : Available_Methods.BaseSendArgs
    {
        /// <summary>Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "sticker", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [InputFile("sticker")]
        public object Sticker { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
    }
}