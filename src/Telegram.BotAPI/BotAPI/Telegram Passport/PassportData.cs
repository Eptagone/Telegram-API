// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Contains information about Telegram Passport data shared with the bot by the user.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportData
    {
        /// <summary>Array with information about documents and other Telegram Passport elements that was shared with the bot.</summary>
        [JsonPropertyName("data")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<EncryptedPassportElement> Data { get; set; }
        /// <summary>Encrypted credentials required to decrypt the data.</summary>
        [JsonPropertyName("credentials")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EncryptedCredentials Credentials { get; set; }
    }
}