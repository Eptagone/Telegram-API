// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Stickers
{
    public static partial class StickersMethods
    {
        /// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static Message SendSticker(this BotClient T, SendStickerArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return T.RPCF<Message>("sendSticker", args);
        }
        /// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static async Task<Message> SendStickerAsync(this BotClient T, SendStickerArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            return await T.RPCAF<Message>("sendSticker", args).ConfigureAwait(true);
        }
    }
}