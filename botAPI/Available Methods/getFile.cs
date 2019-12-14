﻿using Newtonsoft.Json.Linq;

namespace TelegramAPI.Available_Methods
{
    public static partial class Available_Methods
    {
        /// <summary>Use this method to get basic info about a file and prepare it for downloading.. On success, a File object is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="file_id">File identifier to get info about.</param>
        /// <returns><see cref="Available_Types.File"/></returns>
        public static Available_Types.File GetFile(this BotClient T, string file_id) => T.RPC<Available_Types.File>("getFile", new JObject { new JProperty("file_id", file_id) });
    }
}