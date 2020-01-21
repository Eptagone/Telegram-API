﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
using Telegram.BotAPI.Available_Types;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>SendVideoNote method arguments.</summary>
    public sealed class SendVideoNoteArgs : BaseSendArgs
    {
        ///<summary>Video note to send. Pass a file_id as String to send a video note that exists on the Telegram servers (recommended) or upload a new video using multipart/form-data.</summary>
        [JsonPropertyName("video_note")]
        [InputFile("video_note")]
        public object Video_note { get; set; }
        ///<summary>Optional. Duration of sent video in seconds.</summary>
        [JsonPropertyName("duration")]
        public uint Duration { get; set; }
        ///<summary>Optional. Video width and height, i.e. diameter of the video message.</summary>
        [JsonPropertyName("length")]
        public uint Length { get; set; }
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonPropertyName("thumb")]
        [InputFile("thumb")]
        public object Thumb { get; set; }
        /// <summary>Attached files.</summary>
        [JsonIgnore]
        public AttachFile[] AttachFiles { get; set; }
        internal bool UseMultipart()
        {
            if (Video_note != default)
                if (Video_note.GetType() == typeof(InputFile))
                    return true;
            if (Thumb != default)
                if (Thumb.GetType() == typeof(InputFile))
                    return true;
            if (AttachFiles != default)
                return true;
            return false;
        }
    }
}