// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="file_id">File identifier to get info about.</param>
        /// <returns><see cref="File"/></returns>
        public static Available_Types.File GetFile(this BotClient T, string file_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("file_id", file_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<Available_Types.File>("getFile", stream);
        }
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="file_id">File identifier to get info about.</param>
        /// <returns><see cref="File"/></returns>
        public static async Task<Available_Types.File> GetFileAsync(this BotClient T, string file_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("file_id", file_id);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<Available_Types.File>("getFile", stream).ConfigureAwait(false);
        }
    }
}