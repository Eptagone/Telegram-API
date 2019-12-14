using Newtonsoft.Json;
using System;
namespace TelegramAPI.Inline_mode
{
    /// <summary>Represents a link to an MP3 audio file stored on the Telegram servers. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
    public class InlineQueryResultCachedAudio : InlineQueryResult
    {
        /// <summary>Type of the result, must be audio.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type => "audio";
        /// <summary>A valid file identifier for the audio file.</summary>
        [JsonProperty(PropertyName = "audio_file_id", Required = Required.Always)]
        public string Audio_file_id { get; set; }
        /// <summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonProperty(PropertyName = "caption", Required = Required.Always)]
        public string Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption..</summary>
        [JsonProperty(PropertyName = "parse_mode", Required = Required.Always)]
        public string Parse_mode { get; set; }
        /// <summary>Title of the result.</summary>
        [Obsolete("Don't use this", true)]
        public new string Title { get; set; }
    }
}
