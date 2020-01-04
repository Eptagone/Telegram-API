﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using TelegramAPI.Available_Types;

namespace TelegramAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker file owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</param>
        public static File UploadStickerFile(this BotClient T, int user_id, InputFile png_sticker)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (png_sticker is null)
                throw new System.ArgumentNullException(nameof(png_sticker));
            return T.RPCF<File>("uploadStickerFile", new UploadStickerFileArgs { User_id = user_id, Png_sticker = png_sticker });
        }

        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static File UploadStickerFile(this BotClient T, UploadStickerFileArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<File>("uploadStickerFile", args);
        }
    }
}