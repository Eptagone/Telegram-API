﻿// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Methods
{
    /// <summary>AnswerCallbackQuery method arguments.</summary>
    public sealed class AnswerCallbackQueryArgs
    {
        ///<summary>Unique identifier for the query to be answered.</summary>
        [JsonPropertyName("callback_query_id")]
        public string Callback_query_id { get; set; }
        ///<summary>Optional. Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
        ///<summary>Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</summary>
        [JsonPropertyName("show_alert")]
        public bool Show_alert { get; set; }
        ///<summary>Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button.<br/> Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
        ///<summary>Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</summary>
        [JsonPropertyName("cache_time")]
        public uint Cache_time { get; set; }
    }
}