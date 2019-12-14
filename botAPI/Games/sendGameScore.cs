using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TelegramAPI.Games
{
    public static partial class Games
    {
        ///<summary>Use this method to set the score of the specified user in a game. On success, if the message was sent by the bot, returns the edited Message, otherwise returns True. Returns an error, if the new score is not greater than the user's current score in the chat and force is False.</summary>
        ///<param name="T">BotClient</param>
        /// <param name="args">Parameters.</param>
        public static dynamic SetGameScore(this BotClient T, SetGameScoreArgs args)
        {
            var json_message = T.RPC<JProperty>("setGameScore", args);
            if (json_message.Type == JTokenType.Object)
                return json_message.ToObject<Available_Types.Message>();
            else
                return json_message.ToObject<bool>();
        }
    }
}
namespace TelegramAPI.Games
{
    /// <summary>SetGameScore method arguments.</summary>
    public class SetGameScoreArgs
    {
        /// <summary>User identifier.</summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.Always)]
        public uint User_id { get; set; }
        /// <summary>New score.</summary>
        [JsonProperty(PropertyName = "score", Required = Required.Always)]
        public uint Score { get; set; }
        /// <summary>Optional. Pass True, if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters.</summary>
        [JsonProperty(PropertyName = "force", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Force { get; set; }
        /// <summary>Optional. Pass True, if the game message should not be automatically edited to include the current scoreboard.</summary>
        [JsonProperty(PropertyName = "disable_edit_message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Disable_edit_message { get; set; }
        /// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat.</summary>
        [JsonProperty(PropertyName = "chat_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Chat_id { get; set; }
        /// <summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonProperty(PropertyName = "message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Message_id { get; set; }
        /// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonProperty(PropertyName = "inline_message_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Inline_message_id { get; set; }
    }
}
