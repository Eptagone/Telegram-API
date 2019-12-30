﻿// Copyright (c) 2019 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;

namespace TelegramAPI.Telegram_Passport
{
    /// <summary>Represents an issue in an unspecified place. The error is considered resolved when new data is added.</summary>
    public class PassportElementErrorUnspecified : PassportElementError
    {
        /// <summary>Error source, must be unspecified.</summary>
        [JsonProperty(PropertyName = "source", Required = Required.Always)]
        public override string Source => "unspecified";
        /// <summary>Type of element of the user's Telegram Passport which has the issue.</summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded element hash.</summary>
        [JsonProperty(PropertyName = "element_hash", Required = Required.Always)]
        public string Element_hash { get; set; }
    }
}