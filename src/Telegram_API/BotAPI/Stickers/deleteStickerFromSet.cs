// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Stickers
{
    public static partial class Stickers
    {
        /// <summary>Use this method to delete a sticker from a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        public static bool DeleteStickerFromSet(this BotClient T, string sticker) => T.RPC<bool>("deleteStickerFromSet", new JObject { new JProperty("sticker", sticker) });
    }
}