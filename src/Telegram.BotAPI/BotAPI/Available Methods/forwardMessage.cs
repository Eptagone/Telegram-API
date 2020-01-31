// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;
using System.Runtime.InteropServices;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>Available Methods</summary>
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <returns>Message Object.</returns>
        public static Message ForwardMessage(this BotClient T, string chat_id, string from_chat_id, uint message_id, [Optional] bool disable_notification)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteString("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Message>("forwardMessage", stream);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <returns>Message Object.</returns>
        public static Message ForwardMessage(this BotClient T, long chat_id, long from_chat_id, uint message_id, [Optional] bool disable_notification)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Message>("forwardMessage", stream);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <returns>Message Object.</returns>
        public static Message ForwardMessage(this BotClient T, string chat_id, long from_chat_id, uint message_id, [Optional] bool disable_notification)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Message>("forwardMessage", stream);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <returns>Message Object.</returns>
        public static Message ForwardMessage(this BotClient T, long chat_id, string from_chat_id, uint message_id, [Optional] bool disable_notification)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Message>("forwardMessage", stream);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> ForwardMessageAsync(this BotClient T, string chat_id, string from_chat_id, uint message_id, [Optional] bool disable_notification, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteString("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Message>("forwardMessage", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> ForwardMessageAsync(this BotClient T, long chat_id, long from_chat_id, uint message_id, [Optional] bool disable_notification, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteNumber("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Message>("forwardMessage", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> ForwardMessageAsync(this BotClient T, string chat_id, long from_chat_id, uint message_id, [Optional] bool disable_notification, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("chat_id", chat_id);
            json.WriteNumber("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Message>("forwardMessage", stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="chat_id">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="from_chat_id">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</param>
        /// <param name="disable_notification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="message_id">Message identifier in the chat specified in from_chat_id.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>Message Object.</returns>
        public static async Task<Message> ForwardMessageAsync(this BotClient T, long chat_id, string from_chat_id, uint message_id, [Optional] bool disable_notification, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("chat_id", chat_id);
            json.WriteString("from_chat_id", from_chat_id);
            json.WriteNumber("message_id", message_id);
            if (disable_notification != default)
                json.WriteBoolean("disable_notification", disable_notification);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Message>("forwardMessage", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}