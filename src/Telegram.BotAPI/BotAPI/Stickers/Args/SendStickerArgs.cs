// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>SendSticker method arguments</summary>
    public sealed class SendStickerArgs : Available_Methods.BaseSendArgs
    {
        /// <summary>Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .webp file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName("sticker")]
        [InputFile("sticker")]
        public object Sticker { get; set; }
        internal bool UseMultipart()
        {
            if (Sticker != default)
                if (Sticker.GetType() == typeof(InputFile))
                    return true;
            return false;
        }
    }
}