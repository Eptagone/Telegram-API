// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Available_Types
{
    /// <summary>This object represents a parameter of the inline keyboard button used to automatically authorize a user. Serves as a great replacement for the Telegram Login Widget when the user is coming from Telegram. All the user needs to do is tap/click a button and confirm that they want to log in</summary>
    public sealed class LoginUrl
    {
        /// <summary>An HTTP URL to be opened with user authorization data added to the query string when the button is pressed. If the user refuses to provide authorization data, the original URL without information about the user will be opened. The data added is the same as described in Receiving authorization data.<para>NOTE: You must always check the hash of the received data to verify the authentication and the integrity of the data as described in Checking authorization.</para></summary>
        [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public System.Uri Url { get; set; }
        /// <summary>Optional. New text of the button in forwarded messages.</summary>
        [JsonProperty(PropertyName = "forward_text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Forward_text { get; set; }
        /// <summary>Optional. Username of a bot, which will be used for user authorization. See <a href="https://core.telegram.org/widgets/login#setting-up-a-bot">Setting up a bot</a> for more details. If not specified, the current bot's username will be assumed. The url's domain must be the same as the domain linked with the bot. See <a href="https://core.telegram.org/widgets/login#linking-your-domain-to-the-bot">Linking your domain</a> to the bot for more details.</summary>
        [JsonProperty(PropertyName = "bot_username", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Bot_username { get; set; }
        /// <summary>Optional. Pass True to request the permission for your bot to send messages to the user.</summary>
        [JsonProperty(PropertyName = "request_write_access", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Request_write_access { get; set; }
    }
}
