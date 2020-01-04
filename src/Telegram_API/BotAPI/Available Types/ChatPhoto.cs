// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a chat photo.</summary>
    public sealed class ChatPhoto
    {
        /// <summary>File identifier of small (160x160) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.</summary>
        [JsonProperty(PropertyName = "small_file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Small_file_id { get; set; }
        /// <summary>Unique file identifier of small (160x160) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "small_file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Small_file_unique_id { get; set; }
        /// <summary>File identifier of big (640x640) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.</summary>
        [JsonProperty(PropertyName = "big_file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Big_file_id { get; set; }
        /// <summary>Unique file identifier of big (640x640) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "big_file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Big_file_unique_id { get; set; }
    }
}