// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>SetPassportDataErrors method parameters.</summary>
    public class SetPassportDataErrorsArgs
    {
        /// <summary>User identifier.</summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; }
        /// <summary>A <see cref="PassportElementError"/> array describing the errors.</summary>
        [JsonPropertyName("errors")]
        public PassportElementError[] Errors { get; set; }
    }
}
