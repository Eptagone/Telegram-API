// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    ///<summary>Represents a video to be sent.</summary>
    public class InputMediaVideo : InputMedia
    {
        ///<summary>Type of the result, must be video.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "video";
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
        [JsonProperty(PropertyName = "thumb", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Thumb { get; set; }
        ///<summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonProperty(PropertyName = "parse_mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Video width.</summary>
        [JsonProperty(PropertyName = "width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonProperty(PropertyName = "height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>Optional. Video duration.</summary>
        [JsonProperty(PropertyName = "duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Pass True, if the uploaded video is suitable for streaming.</summary>
        [JsonProperty(PropertyName = "supports_streaming", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Supports_streaming { get; set; }
    }
}