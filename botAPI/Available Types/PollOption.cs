using Newtonsoft.Json;
namespace TelegramAPI.Available_Types
{
    /// <summary>This object contains information about one answer option in a poll.</summary>
    public class PollOption
    {
        /// <summary>Option text, 1-100 characters.</summary>
        [JsonProperty(PropertyName = "test", Required = Required.Always)]
        public string Text { get; set; }
        /// <summary>Number of users that voted for this option.</summary>
        [JsonProperty(PropertyName = "voter_count", Required = Required.Always)]
        public uint Voter_count { get; set; }
    }
}
