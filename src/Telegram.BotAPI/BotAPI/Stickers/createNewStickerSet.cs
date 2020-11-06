// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool CreateNewStickerSet(this BotClient T, CreateNewStickerSetArgs args)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return T.RPCF<bool>("createNewStickerSet", args);
            }
            else
            {
                return T.RPC<bool>("createNewStickerSet", args);
            }
        }
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> CreateNewStickerSetAsync(this BotClient T, CreateNewStickerSetArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return await T.RPCAF<bool>("createNewStickerSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await T.RPCA<bool>("createNewStickerSet", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}