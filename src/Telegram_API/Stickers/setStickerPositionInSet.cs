// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;

namespace TelegramAPI.Stickers
{
    /// <summary>Stickers</summary>
    public static partial class Stickers
    {
        /// <summary>Use this method to move a sticker in a set created by the bot to a specific position . Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="sticker">File identifier of the sticker.</param>
        /// <param name="position">New sticker position in the set, zero-based.</param>
        public static bool SetStickerPositionInSet(this BotClient T, string sticker, int position) => T.RPC<bool>("setStickerPositionInSet", new JObject { new JProperty("sticker", sticker), new JProperty("position", position) });
    }
}