﻿using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Contains information about documents or other Telegram Passport elements shared with the bot by the user.</summary>
    public class EncryptedPassportElement
    {
        /// <summary>Element type. One of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”, “phone_number”, “email”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Type { get; set; }
        /// <summary>Optional. Base64-encoded encrypted Telegram Passport element data provided by the user, available for “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport” and “address” types. Can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
        [JsonProperty(PropertyName = "data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Data { get; set; }
        /// <summary>Optional. User's verified phone number, available only for “phone_number” type.</summary>
        [JsonProperty(PropertyName = "phone_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_number { get; set; }
        /// <summary>Optional. User's verified email address, available only for “email” type.</summary>
        [JsonProperty(PropertyName = "email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        /// <summary>Optional. Array of encrypted files with documents provided by the user, available for “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
        [JsonProperty(PropertyName = "files", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportFile[] Files { get; set; }
        /// <summary>Optional. Encrypted file with the front side of the document, provided by the user. Available for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
        [JsonProperty(PropertyName = "front_side", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportFile Front_side { get; set; }
        /// <summary>Optional. Encrypted file with the reverse side of the document, provided by the user. Available for “driver_license” and “identity_card”. The file can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
        [JsonProperty(PropertyName = "reverse_side", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportFile Reverse_side { get; set; }
        /// <summary>Optional. Encrypted file with the selfie of the user holding a document, provided by the user; available for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
        [JsonProperty(PropertyName = "selfie", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportFile Selfie { get; set; }
        /// <summary>Optional. Array of encrypted files with translated versions of documents provided by the user. Available if requested for “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying EncryptedCredentials.</summary>
        [JsonProperty(PropertyName = "translation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PassportFile[] Translation { get; set; }
        /// <summary>Base64-encoded element hash for using in PassportElementErrorUnspecified.</summary>
        [JsonProperty(PropertyName = "hash", Required = Required.Always)]
        public string Hash { get; set; }
    }
}
