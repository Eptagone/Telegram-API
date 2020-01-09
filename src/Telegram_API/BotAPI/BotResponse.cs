using Newtonsoft.Json;

namespace TelegramAPI
{
    /// <summary>Represents the bot's response to the request.</summary>
    /// <typeparam name="T">Result type.</typeparam>
    public sealed class BotResponse<T>
    {
        /// <summary>True, if the request was successful, otherwise false.</summary>
        [JsonProperty("ok", Required = Required.Always)]
        public bool Ok { get; set; }
        /// <summary>Result.</summary>
        [JsonProperty("result", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public T Result { get; set; }
        ///<summary>Error code.</summary>
        [JsonProperty("error_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Error_code { get; set; }
        ///<summary>Error description.</summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}
