// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;
namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>Contains data required for decrypting and authenticating EncryptedPassportElement. See the <a href="https://core.telegram.org/passport#receiving-information">Telegram Passport Documentation</a> for a complete description of the data decryption and authentication processes.</summary>
    public sealed class EncryptedCredentials
    {
        /// <summary>Base64-encoded encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication.</summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
        /// <summary>Base64-encoded data hash for data authentication.</summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }
        /// <summary>Base64-encoded secret, encrypted with the bot's public RSA key, required for data decryption.</summary>
        [JsonPropertyName("secret")]
        public string Secret { get; set; }
    }
}
