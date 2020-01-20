// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>EditMessageLiveLocation method arguments.</summary>
    public sealed class EditMessageLiveLocationArgs
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName("chat_id")]
        public object Chat_id { get; set; }
        ///<summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonPropertyName("message_id")]
        public uint Message_id { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName("inline_message_id")]
        public string Inline_message_id { get; set; }
        ///<summary>Latitude of new location.</summary>
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        ///<summary>Longitude of new location.</summary>
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        ///<summary>Optional. A <see cref="Available_Types.InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
        [JsonPropertyName("reply_markup")]
        public Available_Types.InlineKeyboardMarkup Reply_markup { get; set; }
    }
}