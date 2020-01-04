// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents an audio file to be treated as music by the Telegram clients.</summary>
    public sealed class Audio
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_id { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonProperty(PropertyName = "file_unique_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File_unique_id { get; set; }
        ///<summary>Optional. Performer of the audio as defined by sender or by audio tags.</summary>
        [JsonProperty(PropertyName = "performer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; set; }
        ///<summary>Optional. Title of the audio as defined by sender or by audio tags.</summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Optional. MIME type of the file as defined by sender.</summary>
        [JsonProperty(PropertyName = "mime_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mime_type { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonProperty(PropertyName = "file_size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint File_size { get; set; }
        ///<summary>Optional. Thumbnail of the album cover to which the music file belongs.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
    }
}