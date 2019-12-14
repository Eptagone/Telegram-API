using Newtonsoft.Json;

namespace TelegramAPI.Available_Methods
{
    /// <summary>SendPoll method arguments.</summary>
    public class SendPollArgs : BaseSendArgs
    {
        ///<summary>Poll question, 1-255 characters.</summary>
        [JsonProperty(PropertyName = "question", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Question { get; set; }
        ///<summary>List of answer options, 2-10 strings 1-100 characters each.</summary>
        [JsonProperty(PropertyName = "options", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Options { get; set; }
    }
}
