// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to send audio files, if you want Telegram clients to display the file as a playable voice message. For this to work, your audio must be in an .ogg file encoded with OPUS (other formats may be sent as Audio or Document). On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendVoice(this BotClient T, SendVoiceArgs args)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return T.RPCF<Message>("sendVoice", args);
        }
        /// <summary>Use this method to send audio files, if you want Telegram clients to display the file as a playable voice message. For this to work, your audio must be in an .ogg file encoded with OPUS (other formats may be sent as Audio or Document). On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendVoiceAsync(this BotClient T, SendVoiceArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await T.RPCAF<Message>("sendVoice", args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}