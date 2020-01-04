// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Contains information about Telegram Passport data shared with the bot by the user.</summary>
    public sealed class PassportData
    {
        /// <summary>Array with information about documents and other Telegram Passport elements that was shared with the bot.</summary>
        [JsonProperty(PropertyName = "data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EncryptedPassportElement[] Data { get; set; }
        /// <summary>Encrypted credentials required to decrypt the data.</summary>
        [JsonProperty(PropertyName = "credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EncryptedCredentials Credentials { get; set; }
    }
}