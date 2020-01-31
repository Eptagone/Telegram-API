// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
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
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker file owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<File> UploadStickerFileAsync(this BotClient T, int user_id, InputFile png_sticker, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (png_sticker is null)
                throw new System.ArgumentNullException(nameof(png_sticker));
            return await T.RPCAF<File>("uploadStickerFile", new UploadStickerFileArgs { User_id = user_id, Png_sticker = png_sticker }, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<File> UploadStickerFileAsync(this BotClient T, UploadStickerFileArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return await T.RPCAF<File>("uploadStickerFile", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}