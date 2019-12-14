using Newtonsoft.Json;
namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Contains information about Telegram Passport data shared with the bot by the user.</summary>
    public class PassportData
    {
        /// <summary>Array with information about documents and other Telegram Passport elements that was shared with the bot.</summary>
        [JsonProperty(PropertyName = "data", Required = Required.Always)]
        public EncryptedPassportElement[] Data { get; set; }
        /// <summary>Encrypted credentials required to decrypt the data.</summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.Always)]
        public EncryptedCredentials Credentials { get; set; }
    }
}