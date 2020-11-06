// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="custom_title">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetChatAdministratorCustomTitle(
            this BotClient T,
            long chat_id,
            int user_id,
            string custom_title)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteString("custom_title", custom_title);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("sendVideoNote", stream);
        }

        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="custom_title">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetChatAdministratorCustomTitle(
            this BotClient T,
            string chat_id,
            int user_id,
            string custom_title)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteString("custom_title", custom_title);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("sendVideoNote", stream);
        }
        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="custom_title">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetChatAdministratorCustomTitleAsync(this BotClient T, long chat_id, int user_id, string custom_title, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteString("custom_title", custom_title);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("sendVideoNote", stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="T">Bot Client</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="custom_title">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetChatAdministratorCustomTitleAsync(this BotClient T, string chat_id, int user_id, string custom_title, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
            {
                throw new ArgumentNullException(nameof(T));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("user_id", user_id);
            json.WriteString("custom_title", custom_title);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("sendVideoNote", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
