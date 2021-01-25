// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgs_sticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient bot, int user_id, string name, [Optional] string png_sticker, [Optional] InputFile tgs_sticker, string emojis, [Optional] MaskPosition mask_position)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Emojis = emojis };
            if (!string.IsNullOrEmpty(png_sticker))
            {
                args.Png_sticker = png_sticker;
            }

            if (tgs_sticker != default)
            {
                args.Tgs_sticker = tgs_sticker;
            }

            if (mask_position != default)
            {
                args.Mask_position = mask_position;
            }

            if (args.UseMultipart())
            {
                return bot.RPCF<bool>("addStickerToSet", args);
            }
            else
            {
                return bot.RPC<bool>("addStickerToSet", args);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgs_sticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient bot, int user_id, string name, [Optional] string png_sticker, [Optional] InputFile tgs_sticker, string emojis, [Optional] MaskPosition mask_position, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Emojis = emojis };
            if (!string.IsNullOrEmpty(png_sticker))
            {
                args.Png_sticker = png_sticker;
            }

            if (tgs_sticker != default)
            {
                args.Tgs_sticker = tgs_sticker;
            }

            if (mask_position != default)
            {
                args.Mask_position = mask_position;
            }

            if (args.UseMultipart())
            {
                return await bot.RPCAF<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgs_sticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient bot, int user_id, string name, [Optional] InputFile png_sticker, [Optional] InputFile tgs_sticker, string emojis, [Optional] MaskPosition mask_position)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Emojis = emojis };
            if (png_sticker != default)
            {
                args.Png_sticker = png_sticker;
            }

            if (tgs_sticker != default)
            {
                args.Tgs_sticker = tgs_sticker;
            }

            if (mask_position != default)
            {
                args.Mask_position = mask_position;
            }

            if (args.UseMultipart())
            {
                return bot.RPCF<bool>("addStickerToSet", args);
            }
            else
            {
                return bot.RPC<bool>("addStickerToSet", args);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="user_id">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="png_sticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgs_sticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="mask_position">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient bot, int user_id, string name, [Optional] InputFile png_sticker, [Optional] InputFile tgs_sticker, string emojis, [Optional] MaskPosition mask_position, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { User_id = user_id, Name = name, Emojis = emojis };
            if (png_sticker != default)
            {
                args.Png_sticker = png_sticker;
            }

            if (tgs_sticker != default)
            {
                args.Tgs_sticker = tgs_sticker;
            }

            if (mask_position != default)
            {
                args.Mask_position = mask_position;
            }

            if (args.UseMultipart())
            {
                return await bot.RPCAF<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient bot, AddStickerToSetArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return bot.RPCF<bool>("addStickerToSet", args);
            }
            else
            {
                return bot.RPC<bool>("addStickerToSet", args);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient bot, AddStickerToSetArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return await bot.RPCAF<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>("addStickerToSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}