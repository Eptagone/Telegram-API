// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendVideoNote method arguments.</summary>
    public class SendVideoNoteArgs : BaseSendArgs
    {
        ///<summary>Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "video_note", Required = Required.Always)]
        public object Video_note { get; set; }
        ///<summary>Optional. Duration of sent video in seconds.</summary>
        [JsonProperty(PropertyName = "duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Video width and height, i.e. diameter of the video message.</summary>
        [JsonProperty(PropertyName = "length", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Length { get; set; }
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Thumb { get; set; }
    }
}