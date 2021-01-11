// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Updating_messages
{
    public static partial class UpdatingMessagesExtensions
    {
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
        /// <param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static T EditMessageMedia<T>(this BotClient B, EditMessageMediaArgs args)
        {
            if (B == default)
            {
                throw new ArgumentNullException(nameof(B));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.Available_Types.Message or bool.");
            }
            if (args.UseMultipart())
            {
                return B.RPCF<T>("editMessageMedia", args);
            }
            else
            {
                return B.RPC<T>("editMessageMedia", args);
            }
        }
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
        /// <param name="B">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.Available_Types.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<T> EditMessageMediaAsync<T>(this BotClient B, EditMessageMediaArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (B == default)
            {
                throw new ArgumentNullException(nameof(B));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) || typeof(T) != typeof(bool))
            {
                throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.Available_Types.Message or bool.");
            }
            if (args.UseMultipart())
            {
                return await B.RPCAF<T>("editMessageMedia", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await B.RPCA<T>("editMessageMedia", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}