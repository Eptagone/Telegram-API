using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>AnswerCallbackQuery method arguments.</summary>
    public class AnswerCallbackQueryArgs
    {
        ///<summary>Unique identifier for the query to be answered.</summary>
        [JsonProperty(PropertyName = "callback_query_id", Required = Required.Always)]
        public string Callback_query_id { get; set; }
        ///<summary>Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</summary>
        [JsonProperty(PropertyName = "text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</summary>
        [JsonProperty(PropertyName = "show_alert", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Show_alert { get; set; }
        ///<summary>Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button. Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</summary>
        [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        ///<summary>Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</summary>
        [JsonProperty(PropertyName = "cache_time", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Cache_time { get; set; }
    }
}