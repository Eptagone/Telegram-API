﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to delete a sticker from a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        public static bool DeleteStickerFromSet(this BotClient T, string sticker)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("deleteStickerFromSet", new JObject { new JProperty("sticker", sticker) });
        }
        /// <summary>Use this method to delete a sticker from a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        public static async Task<bool> DeleteStickerFromSetAsync(this BotClient T, string sticker)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("deleteStickerFromSet", new JObject { new JProperty("sticker", sticker) }).ConfigureAwait(true);
        }
    }
}