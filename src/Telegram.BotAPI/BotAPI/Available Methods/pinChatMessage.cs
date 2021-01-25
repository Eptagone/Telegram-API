// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to pin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="message_id">Identifier of a message to pin.</param>
        /// <param name="disable_notification">Optional. Pass True, if it is not necessary to send a notification to all chat members about the new pinned message. Notifications are always disabled in channels.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PinChatMessage(this BotClient bot, long chat_id, uint message_id, [Optional] bool disable_notification)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification)
            {
                json.WriteBoolean("disable_notification", true);
            }

            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>("pinChatMessage", stream);
        }
        /// <summary>Use this method to pin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="message_id">Identifier of a message to pin.</param>
        /// <param name="disable_notification">Optional. Pass True, if it is not necessary to send a notification to all chat members about the new pinned message. Notifications are always disabled in channels.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool PinChatMessage(this BotClient bot, string chat_id, uint message_id, [Optional] bool disable_notification)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification)
            {
                json.WriteBoolean("disable_notification", true);
            }

            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>("pinChatMessage", stream);
        }
        /// <summary>Use this method to pin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="message_id">Identifier of a message to pin.</param>
        /// <param name="disable_notification">Optional. Pass True, if it is not necessary to send a notification to all chat members about the new pinned message. Notifications are always disabled in channels.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PinChatMessageAsync(this BotClient bot, long chat_id, uint message_id, [Optional] bool disable_notification, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification)
            {
                json.WriteBoolean("disable_notification", true);
            }

            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>("pinChatMessage", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to pin a message in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the ‘can_pin_messages’ admin right in the supergroup or ‘can_edit_messages’ admin right in the channel. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="message_id">Identifier of a message to pin.</param>
        /// <param name="disable_notification">Optional. Pass True, if it is not necessary to send a notification to all chat members about the new pinned message. Notifications are always disabled in channels.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> PinChatMessageAsync(this BotClient bot, string chat_id, uint message_id, [Optional] bool disable_notification, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification)
            {
                json.WriteBoolean("disable_notification", true);
            }

            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>("pinChatMessage", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}