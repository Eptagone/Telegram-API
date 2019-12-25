// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>This object represents one result of an inline query. Telegram clients currently support results of the following 20 types: <br /><br />
    /// • <see cref="InlineQueryResultCachedDocument"/><br />
    /// • <see cref="InlineQueryResultCachedAudio"/><br />
    /// • <see cref="InlineQueryResultCachedGif"/><br />
    /// • <see cref="InlineQueryResultCachedMpeg4Gif"/><br />
    /// • <see cref="InlineQueryResultCachedPhoto"/><br />
    /// • <see cref="InlineQueryResultCachedSticker"/><br />
    /// • <see cref="InlineQueryResultCachedVideo"/><br />
    /// • <see cref="InlineQueryResultCachedVoice"/><br />
    /// • <see cref="InlineQueryResultArticle"/><br />
    /// • <see cref="InlineQueryResultAudio"/><br />
    /// • <see cref="InlineQueryResultContact"/><br />
    /// • <see cref="InlineQueryResultGame"/><br />
    /// • <see cref="InlineQueryResultDocument"/><br />
    /// • <see cref="InlineQueryResultGif"/><br />
    /// • <see cref="InlineQueryResultLocation"/><br />
    /// • <see cref="InlineQueryResultMpeg4Gif"/><br />
    /// • <see cref="InlineQueryResultPhoto"/><br />
    /// • <see cref="InlineQueryResultVenue"/><br />
    /// • <see cref="InlineQueryResultVideo"/><br />
    /// • <see cref="InlineQueryResultVoice"/></summary>
    public class InlineQueryResult
    {
        /// <summary>Type of the result.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public virtual string Type { get; }
        /// <summary>Unique identifier for this result, 1-64 Bytes.</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }
        /// <summary>Title of the result.</summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; set; }
        /// <summary>Content of the message to be sent.</summary>
        [JsonProperty(PropertyName = "input_message_content", Required = Required.Always)]
        public InputMessageContent Input_message_content { get; set; }
        /// <summary>Optional. Inline keyboard attached to the message.</summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}
