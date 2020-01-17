// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
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
        public static File GetFile(this BotClient T, string file_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return T.RPC<File>("getFile", new JObject { new JProperty("file_id", file_id) });
        }
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="file_id">File identifier to get info about.</param>
        /// <returns><see cref="File"/></returns>
        public static async Task<File> GetFileAsync(this BotClient T, string file_id)
        {
            if (T == default)
                throw new System.ArgumentNullException(nameof(T));
            return await T.RPCA<File>("getFile", new JObject { new JProperty("file_id", file_id) }).ConfigureAwait(true);
        }
    }
}