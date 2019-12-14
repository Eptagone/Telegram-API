using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue with a list of scans. The error is considered resolved when the list of files containing the scans changes.</summary>
    public class PassportElementErrorFiles : PassportElementError
    {
        /// <summary>Error source, must be files.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "files";
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>List of base64-encoded file hashes.</summary>
        [JsonProperty(PropertyName = "file_hashes", Required = Required.Always)]
        public string[] File_hashes { get; set; }
    }
}
