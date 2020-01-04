// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Inline_mode
{
    /// <summary>AnswerInlineQuery method arguments.</summary>
    public sealed class AnswerInlineQueryArgs
    {
        ///<summary>Unique identifier for the answered query.</summary>
        [JsonProperty(PropertyName = "inline_query_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Inline_query_id { get; set; }
        ///<summary>A <see cref="InlineQueryResult"/> array of results for the inline query.</summary>
        [JsonProperty(PropertyName = "results", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineQueryResult[] Results { get; set; }
        ///<summary>The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.</summary>
        [JsonProperty(PropertyName = "cache_time", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Cache_time { get; set; }
        ///<summary>Pass True, if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.</summary>
        [JsonProperty(PropertyName = "is_personal", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Is_personal { get; set; }
        ///<summary>Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don‘t support pagination. Offset length can’t exceed 64 bytes.</summary>
        [JsonProperty(PropertyName = "next_offset", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Next_offset { get; set; }
        ///<summary>If passed, clients will display a button with specified text that switches the user to a private chat with the bot and sends the bot a start message with the parameter switch_pm_parameter.</summary>
        [JsonProperty(PropertyName = "switch_pm_text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Switch_pm_text { get; set; }
        ///<summary>Deep-linking parameter for the /start message sent to the bot when user presses the switch button. 1-64 characters, only A-Z, a-z, 0-9, _ and - are allowed.</summary>
        [JsonProperty(PropertyName = "switch_pm_parameter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Switch_pm_parameter { get; set; }
    }
}