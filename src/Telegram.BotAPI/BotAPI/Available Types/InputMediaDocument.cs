// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>Represents a general file to be sent.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputMediaDocument : InputMedia, IInputMedia, ICaption, IParseMode
    {
        ///<summary>Type of the result, must be document.</summary>
        [JsonPropertyName("type")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "document";
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonPropertyName("thumb")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb { get; set; }
        ///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
        [JsonPropertyName("caption")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName("parse_mode")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Parse_mode { get; set; }
        ///<summary>Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</summary>
        [JsonPropertyName("disable_content_type_detection")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_content_type_detection { get; set; }
    }
}