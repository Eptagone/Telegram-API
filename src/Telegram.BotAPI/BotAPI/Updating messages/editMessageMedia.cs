﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Updating_messages
{
    public static partial class UpdatingMessages
    {
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static dynamic EditMessageMedia(this BotClient T, EditMessageMediaArgs args)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            JsonElement json_result;
            if (args.AttachFiles == default)
                json_result = T.RPC<JsonElement>("editMessageMedia", args);
            else
                json_result = T.RPCF<JsonElement>("editMessageMedia", args);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>Message Object.</returns>
        public static async Task<dynamic> EditMessageMediaAsync(this BotClient T, EditMessageMediaArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            if (args == default)
                throw new System.ArgumentNullException(nameof(args));
            JsonElement json_result;
            if (args.AttachFiles == default)
                json_result = await T.RPCA<JsonElement>("editMessageMedia", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            else
                json_result = await T.RPCAF<JsonElement>("editMessageMedia", args, cancellationToken: cancellationToken).ConfigureAwait(false);
            if (json_result.ValueKind == JsonValueKind.Object)
                return json_result.ToObject<Message>();
            else
                return json_result.GetBoolean();
        }
    }
}