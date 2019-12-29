// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Stickers
{
    public static partial class Stickers
    {
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        public static bool AddStickerToSet(this BotClient T, int user_id, string name, string png_sticker, string emojis) => T.RPC<bool>("addStickerToSet", new JObject { new JProperty("user_id", user_id), new JProperty("name", name), new JProperty("png_sticker", png_sticker), new JProperty("emojis", emojis) });
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        public static bool AddStickerToSet(this BotClient T, int user_id, string name, string png_sticker, string emojis, MaskPosition mask_position = default) => T.RPC<bool>("addStickerToSet", new JObject { new JProperty("user_id", user_id), new JProperty("name", name), new JProperty("png_sticker", png_sticker), new JProperty("emojis", emojis), new JProperty("mask_position", mask_position) });
    }
}