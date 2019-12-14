using Newtonsoft.Json;
namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.</summary>
    public class PassportElementErrorDataField : PassportElementError
    {
        /// <summary>Error source, must be data.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "data";
        /// <summary>The section of the user's Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>Name of the data field which has the error.</summary>
        [JsonProperty(PropertyName = "field_name", Required = Required.Always)]
        public string Field_name { get; set; }
        /// <summary>Base64-encoded data hash.</summary>
        [JsonProperty(PropertyName = "data_hash", Required = Required.Always)]
        public string Data_hash { get; set; }
    }
}
