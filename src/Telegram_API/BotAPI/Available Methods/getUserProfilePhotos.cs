// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Available_Methods
{
    public static partial class AvailableMethods
    {
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
        /// <param name="limit">Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static UserProfilePhotos GetUserProfilePhotos(this BotClient T, int user_id, uint offset = default, ushort limit = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new JObject {
                new JProperty("user_id", user_id)
            };
            if (offset != default)
                args.Add("offset", offset);
            if (limit != default)
                args.Add("limit", limit);
            return T.RPC<UserProfilePhotos>("getUserProfilePhotos", args);
        }
        /// <summary>Use this method to get a list of profile pictures for a user.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="user_id">Unique identifier of the target user.</param>
        /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
        /// <param name="limit">Limits the number of photos to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <returns>UserProfilePhotos Object.</returns>
        public static async Task<UserProfilePhotos> GetUserProfilePhotosAsync(this BotClient T, int user_id, uint offset = default, ushort limit = default)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            var args = new JObject {
                new JProperty("user_id", user_id)
            };
            if (offset != default)
                args.Add("offset", offset);
            if (limit != default)
                args.Add("limit", limit);
            return await T.RPCA<UserProfilePhotos>("getUserProfilePhotos", args).ConfigureAwait(true);
        }
    }
}