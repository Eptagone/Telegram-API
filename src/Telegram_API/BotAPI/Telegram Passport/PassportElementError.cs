// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>This object represents an error in the Telegram Passport element which was submitted that should be resolved by the user. It should be one of:<br/>
    /// • <see cref="PassportElementErrorDataField"/><br/>
    /// • <see cref="PassportElementErrorFrontSide"/><br/>
    /// • <see cref="PassportElementErrorReverseSide"/><br/>
    /// • <see cref="PassportElementErrorSelfie"/><br/>
    /// • <see cref="PassportElementErrorFile"/><br/>
    /// • <see cref="PassportElementErrorFiles"/><br/>
    /// • <see cref="PassportElementErrorTranslationFile"/><br/>
    /// • <see cref="PassportElementErrorTranslationFiles"/><br/>
    /// • <see cref="PassportElementErrorUnspecified"/><br/></summary>
    public class PassportElementError
    {
        /// <summary>Error source.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public virtual string Source { get; set; }
        /// <summary>The section of the user's Telegram Passport which has the issue.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public virtual string Type { get; set; }
        /// <summary>Error message.</summary>
        [JsonProperty(PropertyName = "message", Required = Required.Always)]
        public string Message { get; set; }
    }
}
