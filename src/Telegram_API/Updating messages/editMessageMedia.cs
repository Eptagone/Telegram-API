// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TelegramAPI.Available_Types;

namespace TelegramAPI.Updating_messages
{
    public static partial class Updating_messages
    {
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</summary>
        /// <param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>Message Object.</returns>
        public static dynamic EditMessageMedia(this BotClient T, EditMessageMediaArgs args)
        {
            var json_result = T.RPC<JToken>("editMessageMedia", args);
            if (json_result.Type == JTokenType.Object)
                return json_result.ToObject<Available_Types.Message>();
            else
                return json_result.ToObject<bool>();
        }
    }
}
namespace TelegramAPI.Updating_messages
{
    /// <summary>EditMessageMedia method arguments.</summary>
    public class EditMessageMediaArgs
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Chat_id { get; set; }
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_message_id { get; set; }
        ///<summary>A <see cref="InputMedia"/> object for a new media content of the message.</summary>
        [JsonProperty(PropertyName = "media", Required = Required.Always)]
        public InputMedia Media { get; set; }
        ///<summary>A <see cref="Available_Types.InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
        [JsonProperty(PropertyName = "reply_markup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}