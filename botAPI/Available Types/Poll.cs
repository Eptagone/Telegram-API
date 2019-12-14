using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object contains information about a poll.</summary>
    public class Poll
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }
        /// <summary>Poll question, 1-255 characters.</summary>
        [JsonProperty(PropertyName = "question", Required = Required.Always)]
        public string Question { get; set; }
        /// <summary>List of poll options.</summary>
        [JsonProperty(PropertyName = "options", Required = Required.Always)]
        public PollOption[] Options { get; set; }
        /// <summary>True, if the poll is closed.</summary>
        [JsonProperty(PropertyName = "is_closed", Required = Required.Always)]
        public bool Is_closed { get; set; }
    }
}
