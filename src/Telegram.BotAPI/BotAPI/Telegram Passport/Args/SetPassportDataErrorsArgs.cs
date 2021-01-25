// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Telegram_Passport
{
    /// <summary>SetPassportDataErrors method parameters.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SetPassportDataErrorsArgs
    {
        /// <summary>User identifier.</summary>
        [JsonPropertyName("user_id")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int User_id { get; set; }
        /// <summary>A <see cref="PassportElementError"/> array describing the errors.</summary>
        [JsonPropertyName("errors")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PassportElementError> Errors { get; set; }
    }
}
