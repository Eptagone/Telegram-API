// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Contains data required for decrypting and authenticating EncryptedPassportElement. See the <a href="https://core.telegram.org/passport#receiving-information">Telegram Passport Documentation</a> for a complete description of the data decryption and authentication processes.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EncryptedCredentials
    {
        /// <summary>Base64-encoded encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication.</summary>
        [JsonPropertyName("data")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Data { get; set; }
        /// <summary>Base64-encoded data hash for data authentication.</summary>
        [JsonPropertyName("hash")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Hash { get; set; }
        /// <summary>Base64-encoded secret, encrypted with the bot's public RSA key, required for data decryption.</summary>
        [JsonPropertyName("secret")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Secret { get; set; }
    }
}
