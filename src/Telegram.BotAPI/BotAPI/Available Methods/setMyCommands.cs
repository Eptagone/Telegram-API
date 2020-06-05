// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to change the list of the bot's commands. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetMyCommands(this BotClient T, BotCommand[] commands)
        {
            if (T == null)
                throw new ArgumentNullException(nameof(T));
            if (commands == default)
                throw new ArgumentNullException(nameof(commands));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteStartArray("commands");
            foreach (var cmd in commands)
            {
                if (string.IsNullOrEmpty(cmd.Command) || string.IsNullOrEmpty(cmd.Description))
                    throw new ArgumentNullException($"{nameof(commands)} properties can't be null");
                json.WriteStartObject();
                json.WriteString("command", cmd.Command);
                json.WriteString("description", cmd.Description);
                json.WriteEndObject();
            }
            json.WriteEndArray();
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<bool>("setMyCommands", stream);
        }
        /// <summary>Use this method to change the list of the bot's commands. Returns True on success.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="commands">A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetMyCommandsAsync(this BotClient T, BotCommand[] commands, [Optional] CancellationToken cancellationToken)
        {
            if (T == null)
                throw new ArgumentNullException(nameof(T));
            if (commands == default)
                throw new ArgumentNullException(nameof(commands));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteStartArray("commands");
            foreach (var cmd in commands)
            {
                if (string.IsNullOrEmpty(cmd.Command) || string.IsNullOrEmpty(cmd.Description))
                    throw new ArgumentNullException($"{nameof(commands)} properties can't be null");
                json.WriteStartObject();
                json.WriteString("command", cmd.Command);
                json.WriteString("description", cmd.Description);
                json.WriteEndObject();
            }
            json.WriteEndArray();
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<bool>("setMyCommands", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
