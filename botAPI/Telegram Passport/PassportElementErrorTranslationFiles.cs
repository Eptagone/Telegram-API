using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue with the translated version of a document. The error is considered resolved when a file with the document translation change.</summary>
    public class PassportElementErrorTranslationFiles : PassportElementError
    {
        /// <summary>Error source, must be translation_files.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "translation_files";
        /// <summary>Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>List of base64-encoded file hashes.</summary>
        [JsonProperty(PropertyName = "file_hashes", Required = Required.Always)]
        public string[] File_hashes { get; set; }
    }
}
