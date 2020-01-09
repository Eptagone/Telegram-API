// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;

namespace TelegramAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool CreateNewStickerSet(this BotClient T, CreateNewStickerSetArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<bool>("createNewStickerSet", args);
        }
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<bool> CreateNewStickerSetAsync(this BotClient T, CreateNewStickerSetArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return await T.RPCAF<bool>("createNewStickerSet", args).ConfigureAwait(true);
        }
    }
}