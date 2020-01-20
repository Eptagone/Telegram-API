// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    ///<summary>Represents a video to be sent.</summary>
    public sealed class InputMediaVideo : InputMedia
    {
        ///<summary>Type of the result, must be video.</summary>
        [JsonPropertyName("type")]
        public override string Type => "video";
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
        [JsonPropertyName("thumb")]
        public string Thumb { get; set; }
        ///<summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        public override string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Video width.</summary>
        [JsonPropertyName("width")]
        public uint Width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName("height")]
        public uint Height { get; set; }
        ///<summary>Optional. Video duration.</summary>
        [JsonPropertyName("duration")]
        public uint Duration { get; set; }
        ///<summary>Optional. Pass True, if the uploaded video is suitable for streaming.</summary>
        [JsonPropertyName("supports_streaming")]
        public bool Supports_streaming { get; set; }
    }
}