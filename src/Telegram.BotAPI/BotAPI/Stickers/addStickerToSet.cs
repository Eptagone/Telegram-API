// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        public static bool AddStickerToSet(this BotClient T, int user_id, string name, string png_sticker, string emojis, [Optional] MaskPosition mask_position)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Png_sticker = png_sticker, Emojis = emojis };
            if (mask_position != default)
                args.Mask_position = mask_position;
            return T.RPC<bool>("addStickerToSet", args);
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<bool> AddStickerToSetAsync(this BotClient T, int user_id, string name, string png_sticker, string emojis, [Optional] MaskPosition mask_position, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Png_sticker = png_sticker, Emojis = emojis };
            if (mask_position != default)
                args.Mask_position = mask_position;
            return await T.RPCA<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        public static bool AddStickerToSet(this BotClient T, int user_id, string name, InputFile png_sticker, string emojis, [Optional] MaskPosition mask_position)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Png_sticker = png_sticker, Emojis = emojis };
            if (mask_position != default)
                args.Mask_position = mask_position;
            return T.RPCF<bool>("addStickerToSet", args);
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<bool> AddStickerToSetAsync(this BotClient T, int user_id, string name, InputFile png_sticker, string emojis, [Optional] MaskPosition mask_position, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Png_sticker = png_sticker, Emojis = emojis };
            if (mask_position != default)
                args.Mask_position = mask_position;
            return await T.RPCAF<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static bool AddStickerToSet(this BotClient T, AddStickerToSetArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<bool>("addStickerToSet", args);
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        public static async Task<bool> AddStickerToSetAsync(this BotClient T, AddStickerToSetArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            if(args.UseMultipart())
                return await T.RPCAF<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            else
                return await T.RPCA<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}