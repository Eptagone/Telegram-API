// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TelegramAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to get a sticker set. On success, a StickerSet object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Name of the sticker set.</param>
        /// <returns><see cref="StickerSet"/> object.</returns>
        public static StickerSet GetStickerSet(this BotClient T, string name)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<StickerSet>("getStickerSet", new JObject { new JProperty("name", name) });
        }
        /// <summary>Use this method to get a sticker set. On success, a StickerSet object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="name">Name of the sticker set.</param>
        /// <returns><see cref="StickerSet"/> object.</returns>
        public static async Task<StickerSet> GetStickerSetAsync(this BotClient T, string name)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<StickerSet>("getStickerSet", new JObject { new JProperty("name", name) }).ConfigureAwait(true);
        }
    }
}