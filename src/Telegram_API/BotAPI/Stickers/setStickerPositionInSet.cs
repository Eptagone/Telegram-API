﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Stickers
{
    /// <summary>Stickers</summary>
    public static partial class StickersMethods
    {
        /// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        /// <param name="position">New sticker position in the set, zero-based.</param>
        public static bool SetStickerPositionInSet(this BotClient T, string sticker, int position)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<bool>("setStickerPositionInSet", new JObject { new JProperty("sticker", sticker), new JProperty("position", position) });
        }
        /// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        /// <param name="position">New sticker position in the set, zero-based.</param>
        public static async Task<bool> SetStickerPositionInSetAsync(this BotClient T, string sticker, int position)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<bool>("setStickerPositionInSet", new JObject { new JProperty("sticker", sticker), new JProperty("position", position) }).ConfigureAwait(true);
        }
    }
}