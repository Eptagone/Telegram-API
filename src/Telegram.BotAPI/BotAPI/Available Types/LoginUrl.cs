// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Available_Types
{
    /// <summary>This object represents a parameter of the inline keyboard button used to automatically authorize a user. Serves as a great replacement for the Telegram Login Widget when the user is coming from Telegram. All the user needs to do is tap/click a button and confirm that they want to log in</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class LoginUrl
    {
        /// <summary>New LoginUrl</summary>
        /// <param name="url">An HTTP URL to be opened with user authorization data added to the query string when the button is pressed. If the user refuses to provide authorization data, the original URL without information about the user will be opened. The data added is the same as described in Receiving authorization data.<para>NOTE: You must always check the hash of the received data to verify the authentication and the integrity of the data as described in Checking authorization.</para></param>
        public LoginUrl(string url)
        {
            Url = url;
        }

        /// <summary>An HTTP URL to be opened with user authorization data added to the query string when the button is pressed. If the user refuses to provide authorization data, the original URL without information about the user will be opened. The data added is the same as described in Receiving authorization data.<para>NOTE: You must always check the hash of the received data to verify the authentication and the integrity of the data as described in Checking authorization.</para></summary>
        [JsonPropertyName("url")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; }
        /// <summary>Optional. New text of the button in forwarded messages.</summary>
        [JsonPropertyName("forward_text")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Forward_text { get; set; }
        /// <summary>Optional. Username of a bot, which will be used for user authorization. See <a href="https://core.telegram.org/widgets/login#setting-up-a-bot">Setting up a bot</a> for more details. If not specified, the current bot's username will be assumed. The url's domain must be the same as the domain linked with the bot. See <a href="https://core.telegram.org/widgets/login#linking-your-domain-to-the-bot">Linking your domain</a> to the bot for more details.</summary>
        [JsonPropertyName("bot_username")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Bot_username { get; set; }
        /// <summary>Optional. Pass True to request the permission for your bot to send messages to the user.</summary>
        [JsonPropertyName("request_write_access")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Request_write_access { get; set; }
    }
}
