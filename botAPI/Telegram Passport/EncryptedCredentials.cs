using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Contains data required for decrypting and authenticating EncryptedPassportElement. See the <a href="https://core.telegram.org/passport#receiving-information">Telegram Passport Documentation</a> for a complete description of the data decryption and authentication processes.</summary>
    public class EncryptedCredentials
    {
        /// <summary>Base64-encoded encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication.</summary>
        [JsonProperty(PropertyName = "data", Required = Required.Always)]
        public string Data { get; set; }
        /// <summary>Base64-encoded data hash for data authentication.</summary>
        [JsonProperty(PropertyName = "hash", Required = Required.Always)]
        public string Hash { get; set; }
        /// <summary>Base64-encoded secret, encrypted with the bot's public RSA key, required for data decryption.</summary>
        [JsonProperty(PropertyName = "secret", Required = Required.Always)]
        public string Secret { get; set; }
    }
}
