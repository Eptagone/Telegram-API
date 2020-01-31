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
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="offset">Optional. Sequential number of the first photo to be returned. By default, all photos are returned.</param>
        /// <param name="limit">Optional. Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static UserProfilePhotos GetUserProfilePhotos(this BotClient T, int user_id, [Optional] uint offset, [Optional] ushort limit)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("user_id", user_id);
            if (offset != default)
                json.WriteNumber("offset", offset);
            if (limit != default)
                json.WriteNumber("limit", limit);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return T.RPC<UserProfilePhotos>("getUserProfilePhotos", stream);
        }
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
        /// <param name="limit">Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static async Task<UserProfilePhotos> GetUserProfilePhotosAsync(this BotClient T, int user_id, [Optional] uint offset, [Optional] ushort limit, [Optional] CancellationToken cancellationToken)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber("user_id", user_id);
            if (offset != default)
                json.WriteNumber("offset", offset);
            if (limit != default)
                json.WriteNumber("limit", limit);
            json.WriteEndObject();
            await json.FlushAsync().ConfigureAwait(false);
            await json.DisposeAsync();
            stream.Seek(0, SeekOrigin.Begin);
            return await T.RPCA<UserProfilePhotos>("getUserProfilePhotos", stream, cancellationToken).ConfigureAwait(false);
        }
    }
}